using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DisableInputField : MonoBehaviour
{
    public TMP_InputField inputField; // Référence vers votre InputField TMP

    private void Start()
    {
        inputField.interactable = false; // Désactive l'InputField au démarrage de la scène
    }
}
