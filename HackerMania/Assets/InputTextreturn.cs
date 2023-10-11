using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputTextreturn : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button connectionButton;

    private void Start()
    {
        // Ajoutez un écouteur d'événement au champ de texte pour détecter la touche "Entrée".
        inputField.onEndEdit.AddListener(OnInputFieldEndEdit);
    }

    private void OnInputFieldEndEdit(string text)
    {
        // Vérifiez si la touche appuyée est "Entrée" (Return).
        if (Input.GetKey(KeyCode.Backspace))
        {
            // Appuyez sur le bouton de connexion.
            connectionButton.onClick.Invoke();
        }
    }
}