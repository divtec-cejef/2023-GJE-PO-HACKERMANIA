using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangementInteraction : MonoBehaviour
{
    public float maxDistance = 2.0f;
    public string sceneName;
    public PlayerMovement playerMovement;
    private static bool isFirstInteraction = true;

    private void Update()
    {
        if (Vector2.Distance(transform.position, playerMovement.transform.position) <= maxDistance 
            && Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            VariablesGlobales.PlayerPosition = transform.position;

            // Vérifie si c'est la première interaction
            if (isFirstInteraction)
            {
                // Ajoute 1 à ObjectifIndex
                VariablesGlobales.ObjectifIndex++;
                
                // Définit isFirstInteraction à false pour les interactions suivantes
                isFirstInteraction = false;
            }

            // Enregistre la référence au script PlayerMovement
            VariablesGlobales.PlayerMovementInstance = playerMovement;

            // Charge la nouvelle scène de manière additive
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }
    }
}
