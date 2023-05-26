using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBoxManage : MonoBehaviour
{
    public GameObject CanvasTextBox;
    public string Texte = "";
    public TMP_Text DialogueText;

    private bool isDialogueActive = false;

    // Start is called before the first frame update
    void Start()
    {
        CanvasTextBox.SetActive(false); 
    }

    public void OnClickButton()
    {
        if (!isDialogueActive)
        {
            isDialogueActive = true;
            CanvasTextBox.SetActive(true);
            DialogueText.text = Texte;
            Debug.Log("Dialogue lanc�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && isDialogueActive)
        {
            CanvasTextBox.SetActive(false); // d�sactive la bo�te de dialogue lorsque la touche "Enter" est enfonc�e
            isDialogueActive = false;
            Debug.Log("Dialogue termin�");
        }
    }
}

