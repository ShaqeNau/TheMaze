using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PointerListener : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float rotationValue;
    Maze maze;
    bool pressed = false;
    void Awake()
    {
        maze = FindObjectOfType<Maze>();
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
            maze.Rotate(rotationValue);
        }
    }

}