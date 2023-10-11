using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ConnectionButtonScript : MonoBehaviour
{
    private PasswordController passwordController;
    public PlayerMovement playerMovement;
    public GameObject canvasObject;
    public GameObject fauxMDPTexte;
    public TMP_InputField passwordInput;
    public static bool isFirstInteraction = true;
    public bool isCanvasVisible = false;

    private void Start()
    {
        fauxMDPTexte.SetActive(false);
        canvasObject.SetActive(false);
    }

    public void OnClickButton()
    {
        if (passwordInput.text == "VOITURE")
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