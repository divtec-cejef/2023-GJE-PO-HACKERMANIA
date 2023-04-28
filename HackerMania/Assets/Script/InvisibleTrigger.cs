using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InvisibleTrigger : MonoBehaviour
{
    public GameObject dialogueBox;
    public TMP_Text dialogueText;

    private void Start()
    {
        dialogueBox.SetActive(false); // d�sactive la bo�te de dialogue au d�marrage de la sc�ne
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueBox.SetActive(true);
            dialogueText.text = "Trigger invisible";
            Debug.Log("Dialogue lanc�");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueBox.SetActive(false);
            Debug.Log("Dialogue termin�");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && dialogueBox.activeSelf)
        {
            dialogueBox.SetActive(false); // d�sactive la bo�te de dialogue lorsque la touche "Enter" est enfonc�e
            Debug.Log("Dialogue termin�");
        }
    }
}