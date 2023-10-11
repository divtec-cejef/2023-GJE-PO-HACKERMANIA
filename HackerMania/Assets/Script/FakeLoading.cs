using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FakeLoading : MonoBehaviour
{
    public Slider loadingSlider;
    public float fakeLoadTime = 3.0f; // Temps de chargement simulé en secondes

    private bool isLoadStarted = false;

    public void StartLoading()
    {
        if (!isLoadStarted)
        {
            StartCoroutine(SimulateLoading());
            isLoadStarted = true;
        }
    }

    IEnumerator SimulateLoading()
    {
        float elapsedTime = 0.0f;

        while (elapsedTime < fakeLoadTime)
        {
            float progress = elapsedTime / fakeLoadTime; // Calcul du progrès (0.0f à 1.0f)
            loadingSlider.value = progress; // Mettre à jour la valeur de la barre de chargement

            elapsedTime += Time.deltaTime; // Augmenter le temps écoulé
            yield return null; // Attendre le prochain frame
        }

        // Chargement terminé
        loadingSlider.value = 1.0f; // S'assurer que la barre est pleine à 100%
        Debug.Log("Chargement terminé !");
    }
}