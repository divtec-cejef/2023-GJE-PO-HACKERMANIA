using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class KeyInput : MonoBehaviour
{
    public TMP_InputField inputField;

    public void AddKey()
{
    if (Input.GetKey(KeyCode.JoystickButton0))
    {
        string key = gameObject.name;
        
        if (key == "BackSpace")
        {
            // Retire la dernière lettre du texte
            if (inputField.text.Length > 0)
            {
                inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
            }
        }
        else if (key == "Annuler")
        {
            // Utile pour le Digicode avant la salle administrateur.
            inputField.text = inputField.text.Substring(0, inputField.text.Length - inputField.text.Length);
        }
        else
        {
            // Ajoute la touche à la fin du texte actuel dans le InputField TMP
            inputField.text += key;
        }
    }
}
}
