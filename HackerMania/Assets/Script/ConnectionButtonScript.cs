using UnityEngine;
using UnityEngine.SceneManagement;

public class ConnectionButtonScript : MonoBehaviour
{
    private PasswordController passwordController;
    public PlayerMovement playerMovement;
    public GameObject canvasObject;
    public GameObject fauxMDPTexte;
    public static bool isFirstInteraction = true;
    public bool isCanvasVisible = false;

    private void Start()
    {
        passwordController = FindObjectOfType<PasswordController>();
        fauxMDPTexte.SetActive(false);
        canvasObject.SetActive(false);
    }

    public void OnClickButton()
    {
        if (passwordController != null && passwordController.isPasswordCorrect)
        {
            canvasObject.SetActive(true);
            // Vérifie si c'est la première interaction
            if (isFirstInteraction)
            {
                // Ajoute 1 à ObjectifIndex
                VariablesGlobales.ObjectifIndex++;

                // Définit isFirstInteraction à false pour les interactions suivantes
                isFirstInteraction = false;
            }
        }
        else
        {
            fauxMDPTexte.SetActive(true);
        }
    }
}