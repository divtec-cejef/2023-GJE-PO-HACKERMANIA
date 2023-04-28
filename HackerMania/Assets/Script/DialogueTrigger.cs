using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox;
    public string Texte = "";
    public TMP_Text dialogueText;
    public PlayerMovement playerMovement; // R�f�rence au script de mouvement du joueur

    private bool isDialogueActive = false;

    private void Start()
    {
        dialogueBox.SetActive(false); // d�sactive la bo�te de dialogue au d�marrage de la sc�ne
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
                playerMovement.enabled = false; // D�sactiver le script de mouvement du joueur
                Debug.Log("Dialogue lanc�");
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && isDialogueActive)
        {
            dialogueBox.SetActive(false); // d�sactive la bo�te de dialogue lorsque la touche "Enter" est enfonc�e
            isDialogueActive = false;
            playerMovement.enabled = true; // R�activer le script de mouvement du joueur
            Debug.Log("Dialogue termin�");
        }
    }
}