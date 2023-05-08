using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangementInteraction : MonoBehaviour
{
    public float maxDistance = 2.0f;
    public string sceneName;
    public PlayerMovement playerMovement;

    private void Update()
    {
        if (Vector2.Distance(transform.position, playerMovement.transform.position) <= maxDistance 
            && Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
