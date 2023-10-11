using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextBounce : MonoBehaviour
{
    public Button button;
    public float bounceSpeed = 1.0f;
    public float maxScale = 1.2f;
    public float minScale = 0.8f;

    private void Start()
    {
        StartCoroutine(BounceButton());
    }

    private IEnumerator BounceButton()
    {
        while (true) // Pour une animation en boucle infinie
        {
            yield return BounceToMaxScale();
            yield return BounceToMinScale();
        }
    }

    private IEnumerator BounceToMaxScale()
    {
        Vector3 originalScale = button.transform.localScale;
        Vector3 targetScale = originalScale * maxScale;
        float elapsedTime = 0f;

        while (elapsedTime < 1.0f)
        {
            button.transform.localScale = Vector3.Lerp(originalScale, targetScale, elapsedTime);
            elapsedTime += Time.deltaTime * bounceSpeed;
            yield return null;
        }

        button.transform.localScale = targetScale;
    }

    private IEnumerator BounceToMinScale()
    {
        Vector3 originalScale = button.transform.localScale;
        Vector3 targetScale = originalScale * minScale;
        float elapsedTime = 0f;

        while (elapsedTime < 1.0f)
        {
            button.transform.localScale = Vector3.Lerp(originalScale, targetScale, elapsedTime);
            elapsedTime += Time.deltaTime * bounceSpeed;
            yield return null;
        }

        button.transform.localScale = targetScale;
    }
}