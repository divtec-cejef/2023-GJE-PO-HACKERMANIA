using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] Cinemachine.CinemachineVirtualCamera cam;
    [SerializeField] float targetZoom;
    [SerializeField] float zoomFactor = 3f;
    [SerializeField] float zoomLerpSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        targetZoom = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        float scrollData;
        scrollData =Input.GetAxis("Mouse ScrollWheel");

        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, 4.5f, 18f);
        cam.m_Lens.OrthographicSize = Mathf.Lerp(cam.m_Lens.OrthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed);
    }
}
