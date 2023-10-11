using UnityEngine;

public class DezoomCamera : MonoBehaviour
{
    public float zoomSpeed = 1.0f;
    public float minFieldOfView = 20.0f;
    public float maxFieldOfView = 60.0f;

    public Camera mainCamera;

    private void Start()
    {
        // Assurez-vous d'attacher ce script à la caméra que vous souhaitez dézoomer.
        mainCamera = GetComponent<Camera>();
    }

    private void Update()
    {
        // Utilisez Input.GetAxis("Mouse ScrollWheel") pour obtenir la valeur du défilement de la souris.
        float scrollWheelInput = Input.GetAxis("Mouse ScrollWheel");

        // Modifiez le champ fieldOfView en fonction de l'entrée de la molette de la souris.
        mainCamera.fieldOfView += scrollWheelInput * zoomSpeed;

        // Limitez la valeur du champ fieldOfView pour qu'elle se situe entre minFieldOfView et maxFieldOfView.
        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, minFieldOfView, maxFieldOfView);
    }
}