using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox;
    public string texte = "";
    public TMP_Text dialogueText;
    public PlayerMovement playerMovement;
    public float maxDistance = 2.0f;
    public float dialogueCaractereTime = 0.04f;

    private bool isDialogueActive = false;
    private bool isDialogueInProgress = false; // Added flag to check if dialogue is already in progress

    void Start()
    {
        dialogueBox.SetActive(false);
    }

    void Update()
    {
        if (isDialogueActive && (Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.E)))
        {
            EndDialogue();
        }
        else if (!isDialogueActive && !isDialogueInProgress && Vector2.Distance(transform.position, playerMovement.transform.position) <= maxDistance
            && (Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.E)))
        {
            StartCoroutine(StartDialogue());
        }
    }

    private IEnumerator StartDialogue()
    {
        isDialogueInProgress = true;
        isDialogueActive = true;
        dialogueBox.SetActive(true);
        playerMovement.enabled = false;
        Debug.Log("Dialogue lancé");

        dialogueText.text = string.Empty;

        for (int i = 0; i < texte.Length; i++)
        {
            dialogueText.text += texte[i];
            yield return new WaitForSeconds(dialogueCaractereTime);
        }

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.E));
        EndDialogue();
        isDialogueInProgress = false; // Reset the flag when dialogue ends
    }

    private void EndDialogue()
    {
        isDialogueActive = false;
        dialogueBox.SetActive(false);
        playerMovement.enabled = true;
        dialogueText.text = string.Empty;
        Debug.Log("Dialogue terminé");
    }
}
