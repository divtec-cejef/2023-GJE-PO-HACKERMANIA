using UnityEngine;

public class DisableScriptOnTrigger : MonoBehaviour
{
    public GameObject soundBarObject; // Référence à l'objet contenant le script SoundBar
    private bool hasPassed; // Variable pour suivre si le joueur a déjà passé dessus

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasPassed)
        {
            SoundBar soundBar = soundBarObject.GetComponent<SoundBar>();

            if (soundBar != null)
            {
                soundBar.enabled = false;
                Debug.Log("Script SoundBar désactivé");

                // Ajoute 1 à ObjectifIndex
                VariablesGlobales.ObjectifIndex++;

                hasPassed = true; // Marque que le joueur a déjà passé dessus
            }
            else
            {
                Debug.LogWarning("Le script SoundBar n'est pas attaché à l'objet spécifié.");
            }
        }
    }
}
