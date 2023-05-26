using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class KeyInput : MonoBehaviour
{
    public TMP_InputField inputField; // R�f�rence vers votre InputField TMP

    public void AddKey()
{
    if (Input.GetKey(KeyCode.JoystickButton0))
    {
        string key = gameObject.name; // R�cup�re le nom du bouton (peut �tre utilis� pour d�terminer la touche correspondante)
        
        if (key == "BackSpace")
        {
            // Retire la derni�re lettre du texte
            if (inputField.text.Length > 0)
            {
                inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
            }
        }
        else
        {
            // Ajoute la touche � la fin du texte actuel dans le InputField TMP
            inputField.text += key;
        }
    }
}
}
