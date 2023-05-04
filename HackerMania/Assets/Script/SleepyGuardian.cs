using UnityEngine;

public class SleepyGuardian : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private SpriteRenderer rend;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (playerMovement.isRunning)
        {
            rend.color = Color.red;
        } else {
            rend.color = Color.green;
        }
    }
}