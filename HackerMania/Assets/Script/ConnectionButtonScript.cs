using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConnectionButtonScript : MonoBehaviour
{
    private PasswordController passwordController;
    public string sceneName;
    public GameObject FauxMDPTexte;
    public static bool isFirstInteraction = true;

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
            // Vérifie si c'est la première interaction
            if (isFirstInteraction)
            {
                // Ajoute 1 à ObjectifIndex
                VariablesGlobales.ObjectifIndex++;

                // Définit isFirstInteraction à false pour les interactions suivantes
                isFirstInteraction = false;
            }

        } else {
            FauxMDPTexte.SetActive(true);
        }
    }
}
