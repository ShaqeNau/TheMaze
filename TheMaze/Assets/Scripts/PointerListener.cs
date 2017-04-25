using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PointerListener : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float zoomValue;
    CameraHandler cam;
    bool pressed = false;
    void Awake()
    {
        cam = FindObjectOfType<CameraHandler>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }

    public void Update()
    {
        if (!pressed)
            return;
        else
        {
            cam.Zoom(zoomValue);
        }
    }

}