using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ValiderButtonScript : MonoBehaviour
{
    public TMP_InputField passwordInput;
    public PlayerMovement playerMovement;
    public BoxCollider2D wallCollider; // Référence au composant BoxCollider du mur invisible
    public GameObject canvasObject;

    public string password = "1994"; 

    public static bool isFirstInteraction = true;

    public void OnClickButton()
    {
        if (passwordInput.text == password)  // Vérification du code
        {
            canvasObject.SetActive(false);
            Debug.Log("La salle admin est ouverte");
            playerMovement.enabled = true;
            wallCollider.enabled = false; // Désactiver la collision du mur
            if (isFirstInteraction)
            {
                VariablesGlobales.ObjectifIndex++;
                isFirstInteraction = false;
            }
        }
        else
        {
            Debug.Log("Code incorrect");  // Code incorrect
            wallCollider.enabled = false; // Désactiver la collision du mur (même si le code est incorrect)
        }
    }
}