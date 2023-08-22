using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ValiderButtonScript : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject canvasObject;

    public static bool isFirstInteraction = true;
    public string DigicodePassword = "1994";
    public TMP_InputField inputField;

    private void Start()
    {

    }

    public void OnClickButton()
    {
        if (inputField.text == "1994")  // Vérification du code de l'inputField
            {
                canvasObject.SetActive(false);
                Debug.Log("La salle admin est ouverte");
                playerMovement.enabled = true;

                if (isFirstInteraction)
                {
                    VariablesGlobales.ObjectifIndex++;
                    isFirstInteraction = false;
                }
            }
            else
            {
                Debug.Log("Code incorrect");  // Si le code est incorrrect
            }
        }
}