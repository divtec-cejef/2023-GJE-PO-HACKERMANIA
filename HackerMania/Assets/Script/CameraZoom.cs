using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private Camera cam;
    private float targetZoom;
    private float zoomFactor = 3f;
    private float zoomLerpSpeed = 10f;
    private float joystickZoomSpeed = 2f; // Vitesse de recul avec le joystick

    private void Start()
    {
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
    }

    private void Update()
    {
        float scrollData = Input.GetAxis("Mouse ScrollWheel");

        // Ajouter l'input de la molette de la souris pour le zoom
        float zoomInput = scrollData * zoomFactor;
        
        // Zoom la caméra avec Joystickbutton5
        if (Input.GetKeyDown(KeyCode.JoystickButton5))
        {
            zoomInput += joystickZoomSpeed;
        }
        
        // Dézoom la caméra avec Joystickbutton4
        if (Input.GetKeyDown(KeyCode.JoystickButton4))
        {
            zoomInput -= joystickZoomSpeed;
        }

        targetZoom -= zoomInput;
        targetZoom = Mathf.Clamp(targetZoom, 4.5f, 18f);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed);
    }
}