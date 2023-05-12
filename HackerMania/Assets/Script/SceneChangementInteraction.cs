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

        // Charge la nouvelle sc�ne
        SceneManager.LoadScene(sceneName);
    }

}

    public Vector3 GetPlayerPosition()
    {
        // Renvoie la position du joueur enregistr�e lors de la derni�re interaction
        return playerPosition;
    }
}
