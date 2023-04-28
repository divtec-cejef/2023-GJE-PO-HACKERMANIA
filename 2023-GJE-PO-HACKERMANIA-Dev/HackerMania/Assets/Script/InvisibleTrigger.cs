using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InvisibleTrigger : MonoBehaviour
{
    public GameObject dialogueBox;
    public TMP_Text dialogueText;

    private void Start()
    {
        dialogueBox.SetActive(false); // désactive la boîte de dialogue au démarrage de la scène
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueBox.SetActive(true);
            dialogueText.text = "Trigger invisible";
            Debug.Log("Dialogue lancé");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueBox.SetActive(false);
            Debug.Log("Dialogue terminé");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && dialogueBox.activeSelf)
        {
            dialogueBox.SetActive(false); // désactive la boîte de dialogue lorsque la touche "Enter" est enfoncée
            Debug.Log("Dialogue terminé");
        }
    }
}