using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DisableInputField : MonoBehaviour
{
    public TMP_InputField inputField; // R�f�rence vers votre InputField TMP

    private void Start()
    {
        inputField.interactable = false; // D�sactive l'InputField au d�marrage de la sc�ne
    }
}
