using UnityEngine.SceneManagement;
using UnityEngine;

public class ReturnButton : MonoBehaviour
{
    public void ReturnToPreviousScene()
    {
        // Charge la scène précédente
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1, LoadSceneMode.Single);

        // Restaure la position du joueur à celle stockée dans VariablesGlobales.PlayerPosition
        if (VariablesGlobales.PlayerMovementInstance != null)
        {
            VariablesGlobales.PlayerMovementInstance.transform.position = VariablesGlobales.PlayerPosition;
        }
    }
}
