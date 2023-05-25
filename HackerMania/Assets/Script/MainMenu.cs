using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button BT_Jouer;
    public Button BT_Quitter;
    public string sceneName;

    private void Start()
    {
        BT_Jouer.onClick.AddListener(PlayGame);
        BT_Quitter.onClick.AddListener(QuitGame);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Scene chargée !");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
