using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueButton : MonoBehaviour
{
    public GameObject dialogueBox;
    public string texte = "";
    public TMP_Text dialogueText;
    public PlayerMovement playerMovement; // R�f�rence au script de mouvement du joueur

    private bool isDialogueActive = false;

    void Start()
    {
        dialogueBox.SetActive(false); // D�sactive la bo�te de dialogue au d�marrage de la sc�ne
    }

    public void OnClickButton()
    {
        if (isDialogueActive)
        {
            EndDialogue();
        }
        else
        {
            StartDialogue();
        }
    }

    private void StartDialogue()
    {
        isDialogueActive = true;
        dialogueBox.SetActive(true);
        dialogueText.text = texte;
        playerMovement.enabled = false; // D�sactive le script de mouvement du joueur
        Debug.Log("Dialogue lanc�");
    }

    public void EndDialogue()
    {
        isDialogueActive = false;
        dialogueBox.SetActive(false); // D�sactive la bo�te de dialogue lorsque la touche "Enter" ou "E" est enfonc�e
        playerMovement.enabled = true; // R�active le script de mouvement du joueur
        Debug.Log("Dialogue termin�");
    }
}