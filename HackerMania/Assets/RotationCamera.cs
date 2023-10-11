using UnityEngine;
using System.Collections;

public class RotationCamera : MonoBehaviour
{
    public float rotationSpeed = 180.0f;
    public float rotationDuration = 6.0f;
    public float targetSize = 8.0f;
    public float zoomDuration = 3.0f;

    private bool isRotating = false;

    void Start()
    {
        StartCoroutine(RotateAndZoomCamera());
    }

    IEnumerator RotateAndZoomCamera()
    {
        isRotating = true;

        float elapsedRotationTime = 0.0f;
        float initialRotationZ = transform.eulerAngles.z;
        float targetRotationZ = initialRotationZ + rotationSpeed;

        Camera mainCamera = Camera.main;
        float initialSize = mainCamera.orthographicSize;

        while (elapsedRotationTime < rotationDuration)
        {
            float rotationStep = rotationSpeed * Time.deltaTime;
            float newRotationZ = Mathf.Lerp(initialRotationZ, targetRotationZ, elapsedRotationTime / rotationDuration);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, newRotationZ);

            float zoomProgress = elapsedRotationTime / rotationDuration;
            float zoomStep = Mathf.Lerp(initialSize, targetSize, zoomProgress);
            mainCamera.orthographicSize = zoomStep;

            elapsedRotationTime += Time.deltaTime;
            yield return null;
        }

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, targetRotationZ);
        mainCamera.orthographicSize = targetSize;

        isRotating = false;
    }
}