using UnityEngine;

public class SceneChangementInteraction : MonoBehaviour
{
    public GameObject canvasObject;
    public float maxDistance = 2.0f;
    public PlayerMovement playerMovement;
	public ReturnButton returnButton;

    private bool isCanvasVisible = false;

    private void Start()
    {
        canvasObject.SetActive(false);
    }

    private void Update()
    {
        if (!isCanvasVisible && Vector2.Distance(transform.position, playerMovement.transform.position) <= maxDistance
            && Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            ShowCanvas();
        }
        else if (isCanvasVisible && returnButton.IsPressed == true)
        {
            HideCanvas();
        }
    }

    private void ShowCanvas()
    {
        canvasObject.SetActive(true);
        isCanvasVisible = true;
        playerMovement.enabled = false; // Désactiver le mouvement du joueur si nécessaire
		returnButton.IsPressed = false;
    }

    private void HideCanvas()
    {
        canvasObject.SetActive(false);
        isCanvasVisible = false;
        playerMovement.enabled = true; // Réactiver le mouvement du joueur
    }
}
