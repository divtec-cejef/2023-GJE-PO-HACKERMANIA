using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteSecretariatScript : MonoBehaviour
{
    public BoxCollider2D wallCollider; // Référence au composant BoxCollider du mur invisible
    public Sprite spritePorteOuverte;
    public SpriteRenderer spriteRenderer;

    // Start est appelé avant la première frame
    void Start()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        wallCollider.enabled = true;
    }

    // Update est appelé une fois par frame
    void Update()
    {
        if (VariablesGlobales.DoorSecretariatIsOpen == true)
        {
            Debug.Log("La porte est ouverte !");
            wallCollider.enabled = false; // Activer le collider du mur invisible
            spriteRenderer.sprite = spritePorteOuverte;
        }
        else
        {
            wallCollider.enabled = true; // Désactiver le collider du mur invisible
        }
    }
}
