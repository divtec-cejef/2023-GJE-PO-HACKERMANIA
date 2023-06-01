using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OuvrirPorteSecretariatScript : MonoBehaviour
{
    public bool PorteSecretariatIsOpen;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(SetVariableTrue);
    }

    public void SetVariableTrue()
    {
        VariablesGlobales.DoorSecretariatIsOpen = true; // Permet au booléen contrôlant la porte de se set à 'true'.
    }
}
