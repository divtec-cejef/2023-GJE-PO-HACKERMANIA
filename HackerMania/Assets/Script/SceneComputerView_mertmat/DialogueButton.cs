/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButton : MonoBehaviour
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

public void OnClickButton ()
{
    if (!isDialogueActive)
    {
        isDialogueActive = true;
        CanvasTextBox.SetActive(true);
        DialogueText.text = Texte;
        Debug.Log("Dialogue lancé");
    }
}
private void waitDialogue (float waitTime) {
    yield return new WaitForSeconde()
}

// Update is called once per frame
void Update()
{
        
}
}
*/
