using UnityEngine;

public class ReturnButton : MonoBehaviour
{
    public GameObject canvasObject;
    public PlayerMovement playerMovement;
    public bool IsPressed = false;

    public void CloseTheCanvas()
    {
        canvasObject.SetActive(false);
        playerMovement.enabled = true;
        IsPressed = true;
    }
}