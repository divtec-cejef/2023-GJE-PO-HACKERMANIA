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
            playerMovement.enabled = false; // D�sactiver le script de mouvement du joueur
            dialogueTrigger.enabled = false; // D�sactive le script d'interaction avec un objet
            cameraZoom.enabled = false; // D�sactive le script de zoom de la cam�ra principale
            invisibleTrigger.enabled = false; // D�sactive le script des dialogues invisibles
        }
    }
}