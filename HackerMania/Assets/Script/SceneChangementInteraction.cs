using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangementInteraction : MonoBehaviour
{
    public float maxDistance = 2.0f;
    public string sceneName;
    public PlayerMovement playerMovement;

    public Vector3 playerPosition;

   private void Update()
{
    if (Vector2.Distance(transform.position, playerMovement.transform.position) <= maxDistance 
        && Input.GetKeyDown(KeyCode.Return))
    {
        // Enregistre la position actuelle du joueur
        playerPosition = playerMovement.transform.position;

        // Charge la nouvelle scène
        SceneManager.LoadScene(sceneName);
    }

}

    public Vector3 GetPlayerPosition()
    {
        // Renvoie la position du joueur enregistrée lors de la dernière interaction
        return playerPosition;
    }
}
