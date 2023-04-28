using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button BT_Jouer;
    public Button BT_Quitter;

    private void Start()
    {
        BT_Jouer.onClick.AddListener(PlayGame);
        BT_Jouer.onClick.AddListener(QuitGame);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("HackerMania-PC1");
    }

    public void QuitGame()
{
    Debug.Log("Quitting game...");
    Application.Quit();
}
}