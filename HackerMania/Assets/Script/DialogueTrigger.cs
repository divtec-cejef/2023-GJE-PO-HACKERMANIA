using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox;
    public string texte = "";
    public TMP_Text dialogueText;
    public PlayerMovement playerMovement; // Référence au script de mouvement du joueur

    public float maxDistance = 2.0f; // distance maximale pour déclencher le dialogue

    private bool isDialogueActive = false;

    void Start()
    {
        dialogueBox.SetActive(false); // désactive la boîte de dialogue au démarrage de la scène
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
        playerMovement.enabled = false; // Désactiver le script de mouvement du joueur
        Debug.Log("Dialogue lancé");
    }

    private void EndDialogue()
    {
        isDialogueActive = false;
        dialogueBox.SetActive(false); // désactive la boîte de dialogue lorsque la touche "Enter" ou "E" est enfoncée
        playerMovement.enabled = true; // Réactiver le script de mouvement du joueur
        Debug.Log("Dialogue terminé");
    }
}
