using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class KeyInput : MonoBehaviour
{
    public TMP_InputField inputField; // Référence vers votre InputField TMP

    public void AddKey()
{
    if (Input.GetKey(KeyCode.JoystickButton0))
    {
        string key = gameObject.name; // Récupère le nom du bouton (peut être utilisé pour déterminer la touche correspondante)
        
        if (key == "BackSpace")
        {
            // Retire la dernière lettre du texte
            if (inputField.text.Length > 0)
            {
                inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
            }
        }
        else
        {
            // Ajoute la touche à la fin du texte actuel dans le InputField TMP
            inputField.text += key;
        }
    }
}
}
