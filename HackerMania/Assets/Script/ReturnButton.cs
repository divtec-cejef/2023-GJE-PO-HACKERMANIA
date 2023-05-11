using UnityEngine.SceneManagement;
using UnityEngine;

public class ReturnButton : MonoBehaviour
{
    private SceneChangementInteraction sceneChangementInteraction;

    private void Start()
    {
        // Trouve le script SceneChangementInteraction sur un objet actif dans la scène
        sceneChangementInteraction = FindObjectOfType<SceneChangementInteraction>();
    }

    public void ReturnToPreviousScene()
    {
        // Charge la scène précédente
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1, LoadSceneMode.Single);

        // Restaure la position du joueur à celle stockée dans SceneChangementInteraction
        if (sceneChangementInteraction != null)
        {
            PlayerMovement playerMovement = FindObjectOfType<PlayerMovement>();
            Vector3 position = new Vector3(9.54f, -12f, 0f);
            playerMovement.transform.position = position;
        }
    }
}