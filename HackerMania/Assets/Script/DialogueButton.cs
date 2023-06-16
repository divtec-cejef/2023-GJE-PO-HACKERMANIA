using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueButton : MonoBehaviour
{
    public GameObject dialogueBox;
    public string texte = "";
    public TMP_Text dialogueText;


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
        Debug.Log("Dialogue lancé");
    }

    public void EndDialogue()
    {
        isDialogueActive = false;
        dialogueBox.SetActive(false); // Désactive la boîte de dialogue lorsque la touche "Enter" ou "E" est enfoncée
        Debug.Log("Dialogue terminé");
    }
}