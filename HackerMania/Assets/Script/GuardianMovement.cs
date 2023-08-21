using UnityEngine;

public class GuardianMovement : MonoBehaviour
{
    public Transform[] waypoints = new Transform[4];
    private int currentWaypointIndex;
    private Transform currentWaypoint;
    public float moveSpeed = 3f;
    public GameObject triangleCollider;
    public GameObject player;
    public Canvas gameOverCanvas;
    public PlayerMovement playerMovement;
    
    private bool hasTurned = false; // Pour suivre si le gardien a effectué un quart de tour

    private void Start()
    {
        if (waypoints.Length > 0)
        {
            currentWaypointIndex = 0;
            currentWaypoint = waypoints[currentWaypointIndex];
        }
        else
        {
            Debug.LogError("Veuillez assigner des waypoints au script !");
        }
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, currentWaypoint.position) < 0.1f)
        {
            if (!hasTurned)
            {
                Debug.Log("Le gardien se tourne");
                hasTurned = true;
                // Effectue un quart de tour vers la droite (2D)
                transform.rotation *= Quaternion.Euler(0f, 0f, -90f);
            }

            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            currentWaypoint = waypoints[currentWaypointIndex];
        }
        else
        {
            hasTurned = false; // Réinitialise hasTurned lorsqu'il n'est pas sur un waypoint
        }

        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);

        if (triangleCollider != null && triangleCollider.GetComponent<Collider>().bounds.Contains(player.transform.position))
        {
            ShowGameOverScreen();
        }
    }

    private void ShowGameOverScreen()
    {
        Debug.Log("Game Over");
        gameOverCanvas.gameObject.SetActive(true);
        playerMovement.enabled = false;
    }
}