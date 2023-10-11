using UnityEngine;
using UnityEngine.UI;

public class DisableSlider : MonoBehaviour
{
    public Slider slider;
    public bool isActive = false;

    public void DisableSliderInteractivity()
    {
        if (isActive == false)
        {
            slider.interactable = false; // Désactiver l'interaction avec le slider
        }
    }

    public void EnableSliderInteractivity()
    {
        if (isActive == true)
        {
            slider.interactable = true; // Activer l'interaction avec le slider
        }
    }
}