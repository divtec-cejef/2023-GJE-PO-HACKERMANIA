using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButton : MonoBehaviour
{
    public GameObject dialogueBox;
    public string Texte = "";
    public TMP_Text dialogueText;

    private bool isDialogueActive = false;

    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(false); 
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
                Debug.Log("Dialogue lancé");
            }
        }
    }

    public void OpenTextBox () {
        if (!isDialogueActive) {
                 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
