using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPositionManager : MonoBehaviour
{
    private Vector3 startPosition;  // Position de départ du joueur

    private void Start()
    {
        // Vérifie si la clé de sauvegarde existe
        if (PlayerPrefs.HasKey("PlayerPositionX") &&
            PlayerPrefs.HasKey("PlayerPositionY") &&
            PlayerPrefs.HasKey("PlayerPositionZ"))
        {
            // Restaure la position du joueur à partir des données sauvegardées
            float x = PlayerPrefs.GetFloat("PlayerPositionX");
            float y = PlayerPrefs.GetFloat("PlayerPositionY");
            float z = PlayerPrefs.GetFloat("PlayerPositionZ");
            startPosition = new Vector3(x, y, z);
            transform.position = startPosition;
        }
        else
        {
            // Utilise la position actuelle du joueur comme position de départ
            startPosition = transform.position;
        }
    }

    private void OnDestroy()
    {
        // Sauvegarde la position du joueur avant de quitter la scène
        PlayerPrefs.SetFloat("PlayerPositionX", startPosition.x);
        PlayerPrefs.SetFloat("PlayerPositionY", startPosition.y);
        PlayerPrefs.SetFloat("PlayerPositionZ", startPosition.z);
        PlayerPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        // Efface les données de sauvegarde lorsque l'application est quittée
        PlayerPrefs.DeleteKey("PlayerPositionX");
        PlayerPrefs.DeleteKey("PlayerPositionY");
        PlayerPrefs.DeleteKey("PlayerPositionZ");
        PlayerPrefs.Save();
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        // Efface les données de sauvegarde lorsque l'application est mise en pause
        if (pauseStatus)
        {
            PlayerPrefs.DeleteKey("PlayerPositionX");
            PlayerPrefs.DeleteKey("PlayerPositionY");
            PlayerPrefs.DeleteKey("PlayerPositionZ");
            PlayerPrefs.Save();
        }
    }
}
