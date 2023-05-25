using UnityEngine;

public class AnchorToCamera : MonoBehaviour
{
    private Camera mainCamera;
    private RectTransform canvasRectTransform;
    private Vector2 originalAnchoredPosition;

    public Transform playerTransform;
    public float targetX = -7f;

    private void Start()
    {
        mainCamera = Camera.main;
        canvasRectTransform = GetComponent<RectTransform>();
        originalAnchoredPosition = canvasRectTransform.anchoredPosition;
    }
    
    private void LateUpdate()
    {
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);

        if (viewportPosition.x < 0 || viewportPosition.x > 1 || viewportPosition.y < 0 || viewportPosition.y > 1)
        { 
            canvasRectTransform.anchorMin = new Vector2(0, 1);
            canvasRectTransform.anchorMax = new Vector2(0, 1);
            canvasRectTransform.pivot = new Vector2(0, 1);
            Vector3 playerViewportPosition = mainCamera.WorldToViewportPoint(playerTransform.position);
            Vector2 targetAnchoredPosition = new Vector2(playerViewportPosition.x * mainCamera.pixelWidth - mainCamera.pixelWidth / 2f, originalAnchoredPosition.y);
            canvasRectTransform.anchoredPosition = targetAnchoredPosition;
        }
        else
        {
            canvasRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            canvasRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            canvasRectTransform.pivot = new Vector2(0.5f, 0.5f);
            canvasRectTransform.anchoredPosition = originalAnchoredPosition;
        }
    }
}
