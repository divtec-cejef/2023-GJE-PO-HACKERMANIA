using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractDialogueTrigger : MonoBehaviour
{
    public string sceneName = "Screen";
    private string previousSceneName;

    private void Start()
    {
        // Récupérer le nom de la scène actuelle
        previousSceneName = SceneManager.GetActiveScene().name;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Charger la scène spécifiée
            SceneManager.LoadScene(sceneName);
        }
    }

    private void Update()
    {
    
    }
}