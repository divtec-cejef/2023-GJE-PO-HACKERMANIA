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
            Debug.Log("Dialogue lancé");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && isDialogueActive)
        {
            CanvasTextBox.SetActive(false); // désactive la boîte de dialogue lorsque la touche "Enter" est enfoncée
            isDialogueActive = false;
            Debug.Log("Dialogue terminé");
        }
    }
}

