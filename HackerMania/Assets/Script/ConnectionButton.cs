using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConnectionButton : MonoBehaviour
{
    public PasswordController passwordController;

    private Button connectionButton;

    void Start()
    {
        connectionButton = GetComponent<Button>();
        connectionButton.onClick.AddListener(OpenComputerViewScene);
    }

    void OpenComputerViewScene()
    {
        if (passwordController.isPasswordCorrect)
        {
            SceneManager.LoadScene("ComputerViewScene");
        }
    }
}
