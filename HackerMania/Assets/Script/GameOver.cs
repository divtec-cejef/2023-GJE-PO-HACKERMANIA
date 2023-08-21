using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image healthBar;
    public Canvas gameOverCanvas;
    public PlayerMovement playerMovement;
    public DialogueTrigger dialogueTrigger;
    public Canvas listeObjectifs;

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
            listeObjectifs.gameObject.SetActive(false);
        }
    }
}