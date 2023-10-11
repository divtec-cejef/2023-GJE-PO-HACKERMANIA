using UnityEngine;
using System.Collections;

public class ColorChangeForSecond : MonoBehaviour
{
    public Renderer objectRenderer; 
    public Color color1;
    public Color color2;
    public float colorChangeInterval = 1.0f; // Changement de couleur toutes les 1 seconde.
    
    private void Start()
    {
        StartCoroutine(ChangeColorPeriodically());
    }

    private IEnumerator ChangeColorPeriodically()
    {
        while (true) 
        {
            objectRenderer.material.color = color1;
            yield return new WaitForSeconds(colorChangeInterval); 
            
            objectRenderer.material.color = color2;
            yield return new WaitForSeconds(colorChangeInterval);
        }
    }
}