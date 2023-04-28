using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuTrigger : MonoBehaviour
{
    public float triggerRadius = 2f; // rayon de d�tection du joueur
    public string Texte = "";
    public GameObject menu; // r�f�rence � l'objet du menu
    public Transform player; // r�f�rence au transform du joueur
    public TMP_Text interactText; // R�f�rence au texte.

    private bool isMenuOpen = false; // indique si le menu est actuellement ouvert

    void Start()
    {
        // D�sactiver le menu au d�marrage
        menu.SetActive(false);
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < triggerRadius)
        {
            interactText.gameObject.SetActive(true); // afficher le texte d'interaction
        }
        else
        {
            interactText.gameObject.SetActive(false); // cacher le texte d'interaction
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton0) && Vector2.Distance(transform.position, player.position) < triggerRadius)
        {
            // Si le menu est ferm�, l'ouvrir
            if (!isMenuOpen)
            {
                menu.SetActive(true);
            
                Time.timeScale = 0f; // arr�ter le temps de la sc�ne pour que le jeu soit en pause
                isMenuOpen = true;
            }
            // Sinon, le fermer
            else
            {
                menu.SetActive(false);
                Time.timeScale = 1f; // remettre le temps � sa valeur normale
                isMenuOpen = false;
            }
        }
    }
}
