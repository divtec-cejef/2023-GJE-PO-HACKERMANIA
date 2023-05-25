using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox;
    public string texte = "";
    public TMP_Text dialogueText;
    public PlayerMovement playerMovement; // R�f�rence au script de mouvement du joueur

    public float maxDistance = 2.0f; // distance maximale pour d�clencher le dialogue

    private bool isDialogueActive = false;

    void Start()
    {
        dialogueBox.SetActive(false); // d�sactive la bo�te de dialogue au d�marrage de la sc�ne
    }

    void Update()
    {
        if (isDialogueActive && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E)))
        {
            EndDialogue();
        }
        else if (!isDialogueActive && Vector2.Distance(transform.position, playerMovement.transform.position) <= maxDistance 
            && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E)))
        {
            StartDialogue();
        }
    }

    private void StartDialogue()
    {
        isDialogueActive = true;
        dialogueBox.SetActive(true);
        dialogueText.text = texte;
        playerMovement.enabled = false; // D�sactiver le script de mouvement du joueur
        Debug.Log("Dialogue lanc�");
    }

    private void EndDialogue()
    {
        isDialogueActive = false;
        dialogueBox.SetActive(false); // d�sactive la bo�te de dialogue lorsque la touche "Enter" ou "E" est enfonc�e
        playerMovement.enabled = true; // R�activer le script de mouvement du joueur
        Debug.Log("Dialogue termin�");
    }
}
