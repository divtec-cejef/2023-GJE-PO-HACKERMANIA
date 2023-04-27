using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractDialogueTrigger : MonoBehaviour
{
    public string sceneName = "Screen";
    private string previousSceneName;

    private void Start()
    {
        // R�cup�rer le nom de la sc�ne actuelle
        previousSceneName = SceneManager.GetActiveScene().name;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Charger la sc�ne sp�cifi�e
            SceneManager.LoadScene(sceneName);
        }
    }

    private void Update()
    {
    
    }
}