using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider1; // Référence au premier slider
    public Slider slider2; // Référence au deuxième slider
    public float speed = 1.0f;
    private bool increasing = true;

    private void Start()
    {
        // Désactivez le deuxième slider au démarrage
        slider2.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Return))
        {
            // Vérifiez si la valeur du premier slider est entre 0.7 et 0.8
            if (slider1.value >= 0.7f && slider1.value <= 0.8f)
            {
                // Activez le deuxième slider
                slider2.gameObject.SetActive(true);
                Debug.Log("Le jeu fonctionne...");
                speed = 0;
            }
            else
            {
                slider1.value = 0;
            }
        }

        if (increasing)
        {
            slider1.value += Time.deltaTime * speed;
            if (slider1.value >= 1.0f)
            {
                slider1.value = 1.0f;
                increasing = false;
            }
        }
        else
        {
            slider1.value -= Time.deltaTime * speed;
            if (slider1.value <= 0.0f)
            {
                slider1.value = 0.0f;
                increasing = true;
            }
        }
    }
}