using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasswordController : MonoBehaviour
{
    public TMP_InputField passwordInput;
    public bool isPasswordCorrect = false;
    public string passwordString = "";

    private void Start()
    {
        passwordInput.onValueChanged.AddListener(CheckPassword);
    }

    private void CheckPassword(string password)
    {
        if (password == passwordString)
        {
            isPasswordCorrect = true;
            Debug.Log("Juste");
        }
        else
        {
            isPasswordCorrect = false;
            Debug.Log("Faux");
        }
    }
}