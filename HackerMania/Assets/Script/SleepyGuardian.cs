using UnityEngine;

public class SleepyGuardian : MonoBehaviour
{
    public Color pressedColor; // La couleur � appliquer lorsque la touche est enfonc�e
    public Color releasedColor; // La couleur � appliquer lorsque la touche est rel�ch�e
    public PlayerMovement playermovement;

    private new Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (playermovement.isRunning)) // Si la touche Enter est enfonc�e
        {
            renderer.material.color = pressedColor; // Changer la couleur � la couleur "pressedColor"
            
        }
        else if (Input.GetKeyUp(KeyCode.Return)) // Si la touche Enter est rel�ch�e
        {
            renderer.material.color = releasedColor; // Changer la couleur � la couleur "releasedColor"
            
        }
    }
}