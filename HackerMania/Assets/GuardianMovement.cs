using UnityEngine;

public class Garde : MonoBehaviour
{
    public Transform[] waypoints = new Transform[4];  // Tableau contenant les waypoints à suivre
    private int currentWaypointIndex;  // Indice du waypoint actuel
    private Transform currentWaypoint;  // Waypoint actuel
    public float moveSpeed = 3f;  // Vitesse de déplacement du garde
    public GameObject triangleCollider;  // Référence au collider du triangle

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
        // Vérifie si le garde a atteint le waypoint actuel
        if (Vector3.Distance(transform.position, currentWaypoint.position) < 0.1f)
        {
            // Passe au prochain waypoint
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            currentWaypoint = waypoints[currentWaypointIndex];
        }

        // Déplace le garde vers le waypoint actuel
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);

        // Vérifie si le joueur entre en collision avec le triangle
        if (triangleCollider != null && triangleCollider.GetComponent<Collider>().bounds.Contains(player.transform.position))
        {
            // Affiche l'écran Game Over
            ShowGameOverScreen();
        }
    }

    private void ShowGameOverScreen()
    {
        // Affiche l'écran Game Over (vous pouvez implémenter cela selon votre système d'interface utilisateur)
        Debug.Log("Game Over");
        // Par exemple, vous pouvez désactiver les scripts de contrôle du joueur, afficher un écran de Game Over, etc.
    }
}