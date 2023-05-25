using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image healthBar;
    public Canvas gameOverCanvas;
    public PlayerMovement playerMovement;
    public DialogueTrigger dialogueTrigger;
    public CameraZoom cameraZoom;
    public InvisibleTrigger invisibleTrigger;

    private void Start()
    {
        gameOverCanvas.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (healthBar.fillAmount == 0)
        {
            Debug.Log("Game Over");
            gameOverCanvas.gameObject.SetActive(true);
            playerMovement.enabled = false; // Désactiver le script de mouvement du joueur
            dialogueTrigger.enabled = false; // Désactive le script d'interaction avec un objet
            cameraZoom.enabled = false; // Désactive le script de zoom de la caméra principale
            invisibleTrigger.enabled = false; // Désactive le script des dialogues invisibles
        }
    }
}