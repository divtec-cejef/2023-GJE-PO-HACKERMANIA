using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasVestiareRefile : MonoBehaviour
{
    public CanvasVestiaireInteraction canvasVestiaire;
    public SceneChangementInteraction canvasPC1;
    public ConnectionButtonScript canvasLoginPC1;
    public InvisibleTrigger SortieSalleMachines;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifier si le joueur entre en collision avec l'objet
        if (other.CompareTag("Player"))
        {
            // Définir la variable dans CanvasVestaireInteraction sur true
            canvasVestiaire.isFirstInteraction = true;
            canvasPC1.isFirstInteraction = true;
            canvasLoginPC1.isFirstInteraction = true;


        }
    }
}