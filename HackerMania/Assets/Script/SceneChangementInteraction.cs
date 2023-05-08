using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangementInteraction : MonoBehaviour
{
    public Transform playerTransform;
    public Transform targetTransform;
    public float proximityDistance = 2.0f;
    public string sceneName;

    private void Update()
    {
        float distance = Vector3.Distance(playerTransform.position, targetTransform.position);

        if (distance <= proximityDistance && Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
