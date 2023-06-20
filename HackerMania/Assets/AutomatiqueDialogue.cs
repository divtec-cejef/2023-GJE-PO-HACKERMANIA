using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class AutomatiqueDialogue : MonoBehaviour
{
    public GameObject dialogueBox;
    public TMP_Text dialogueText;
    public float maxDistance = 2.0f;
    public float dialogueCharacterTime = 0.04f;
    public string mainGameSceneName = "MainGame";

    private bool isDialogueActive = false;
    private int dialogueIndex = 0;

    // Ajoutez vos lignes de dialogue ici
    private string[] dialogues = {
        "Allo...allo?",
        "Est-ce que tu me recois ?",
        "Parfait, alors je te brife sur ta mission.",
        "Tu es ici pour t'introduire dans cette entreprise automobile.",
        "J'ai été employé il y a peu de temps... 1 mois enfaite, donc ma carte d'accès n'a pas encore été désactivé.",
        "J'ai découvert que cette entreprise cache l'énorme pollution provoqué par leurs véhicules.",
        "Il faut que tu arrives a atteindre le server pour obtenir le fichier compromettant et que tu me le rapportes.",
        "Quand tu entreras, tu arriveras au secrétariat, la première étape de ta mission.",
        "Attention, il parait qu'un garde est endormi de l'autre cote de la piece, alors attention.",
        "Ne cours surtout pas, il ne faut pas l'alerter",
        "Allez, bonne chance !" 
    };

    private void Start()
    {
        dialogueBox.SetActive(false);
        StartCoroutine(StartDialogue());
    }

    private void Update()
    {
        if (isDialogueActive && (Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.E)))
        {
            if (dialogueIndex < dialogues.Length - 1)
            {
                dialogueIndex++;
                StartCoroutine(PlayDialogue());
            }
            else
            {
                EndDialogue();
                LoadMainGameScene();
            }
        }
    }

    private IEnumerator StartDialogue()
    {
        isDialogueActive = true;
        dialogueBox.SetActive(true);
        yield return StartCoroutine(PlayDialogue());
    }

    private IEnumerator PlayDialogue()
    {
        dialogueText.text = string.Empty;

        string dialogue = dialogues[dialogueIndex];
        for (int i = 0; i < dialogue.Length; i++)
        {
            dialogueText.text += dialogue[i];
            yield return new WaitForSeconds(dialogueCharacterTime);
        }

        yield return null; // Attendre que le joueur appuie sur la touche

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.E));
    }

    private void EndDialogue()
    {
        isDialogueActive = false;
        dialogueBox.SetActive(false);
        dialogueText.text = string.Empty;
        Debug.Log("Dialogue terminé");
    }

    private void LoadMainGameScene()
    {
        SceneManager.LoadScene(mainGameSceneName);
    }
}
