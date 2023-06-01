using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueButton : MonoBehaviour
{
    public GameObject dialogueBox;
    public string texte = "";
    public TMP_Text dialogueText;
    public PlayerMovement playerMovement; // Référence au script de mouvement du joueur

    private bool isDialogueActive = false;

    void Start()
    {
        dialogueBox.SetActive(false); // Désactive la boîte de dialogue au démarrage de la scène
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
        playerMovement.enabled = false; // Désactive le script de mouvement du joueur
        Debug.Log("Dialogue lancé");
    }

    public void EndDialogue()
    {
        isDialogueActive = false;
        dialogueBox.SetActive(false); // Désactive la boîte de dialogue lorsque la touche "Enter" ou "E" est enfoncée
        playerMovement.enabled = true; // Réactive le script de mouvement du joueur
        Debug.Log("Dialogue terminé");
    }
}