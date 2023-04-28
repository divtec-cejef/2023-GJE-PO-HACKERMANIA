using UnityEngine;

public class SleepyGuardian : MonoBehaviour
{
    public Color pressedColor; // La couleur à appliquer lorsque la touche est enfoncée
    public Color releasedColor; // La couleur à appliquer lorsque la touche est relâchée
    public PlayerMovement playermovement;

    private new Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (playermovement.isRunning)) // Si la touche Enter est enfoncée
        {
            renderer.material.color = pressedColor; // Changer la couleur à la couleur "pressedColor"
            
        }
        else if (Input.GetKeyUp(KeyCode.Return)) // Si la touche Enter est relâchée
        {
            renderer.material.color = releasedColor; // Changer la couleur à la couleur "releasedColor"
            
        }
    }
}