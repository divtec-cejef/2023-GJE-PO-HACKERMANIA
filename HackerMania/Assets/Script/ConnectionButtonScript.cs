using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConnectionButtonScript : MonoBehaviour
{
    private PasswordController passwordController;
    public string sceneName;
    public GameObject FauxMDPTexte;

    private void Start()
    {
        passwordController = FindObjectOfType<PasswordController>();
        FauxMDPTexte.SetActive(false);
    }

    public void OnClickButton()
    {
        if (passwordController != null && passwordController.isPasswordCorrect)
        {
            SceneManager.LoadScene(sceneName);
        } else {
            FauxMDPTexte.SetActive(true);
        }
    }
}
