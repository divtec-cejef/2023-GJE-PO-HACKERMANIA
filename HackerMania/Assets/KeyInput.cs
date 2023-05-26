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
            inputField.text += key; // Ajoute la touche � la fin du texte actuel dans le InputField TMP
        }
    }
}
