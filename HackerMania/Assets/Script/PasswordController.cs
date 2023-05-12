using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PasswordController : MonoBehaviour
{
    public TMP_InputField passwordInput;
    public bool isPasswordCorrect = false;
    public string passwordString = "";
    public string sceneName;

    private void Start()
    {
        passwordInput.onValueChanged.AddListener(CheckPassword);
    }

    private void CheckPassword(string password)
    {
        if (password == passwordString)
        {
            Debug.Log("Juste");
            isPasswordCorrect = true;
        }
        else
        {
            isPasswordCorrect = false;
            Debug.Log("Faux");
        }
    }
}