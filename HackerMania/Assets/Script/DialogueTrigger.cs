using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox;
    public string Texte = "";
    public TMP_Text dialogueText;
    public PlayerMovement playerMovement; // Référence au script de mouvement du joueur

    private bool isDialogueActive = false;

    private void Start()
    {
        dialogueBox.SetActive(false); // désactive la boîte de dialogue au démarrage de la scène
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!isDialogueActive)
            {
                isDialogueActive = true;
                dialogueBox.SetActive(true);
                dialogueText.text = Texte;
                playerMovement.enabled = false; // Désactiver le script de mouvement du joueur
                Debug.Log("Dialogue lancé");
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && isDialogueActive)
        {
            dialogueBox.SetActive(false); // désactive la boîte de dialogue lorsque la touche "Enter" est enfoncée
            isDialogueActive = false;
            playerMovement.enabled = true; // Réactiver le script de mouvement du joueur
            Debug.Log("Dialogue terminé");
        }
    }
}