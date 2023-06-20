using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsCanvas;

    private bool isOptionsMenuActive = false;

    private void Update()
    {
        // Vérifie si le bouton JoystickButton9 est enfoncé
        if (Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            // Inverse l'état du menu d'options
            isOptionsMenuActive = !isOptionsMenuActive;

            // Affiche ou masque le canvas d'options
            optionsCanvas.SetActive(isOptionsMenuActive);

            // Met en pause le jeu lorsque le menu d'options est actif
            Time.timeScale = isOptionsMenuActive ? 0f : 1f;
        }
    }

    public void ResumeGame()
    {
        // Masque le canvas d'options
        optionsCanvas.SetActive(false);

        // Réactive le temps de jeu
        Time.timeScale = 1f;
    }
}