using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour {

    public GameObject maze;
    public float speed;
    public float maxZoomIn;
    public float maxZoomOut;

    public void Zoom(float zoomvalue)
    {
        if(zoomvalue > 0)
        {
            if (transform.position.y > maxZoomIn)
            {
                Vector3 temp = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, temp, Time.deltaTime);
            }
        }
        if(zoomvalue < 0)
        {
            if(transform.position.y < maxZoomOut)
            {
                Vector3 temp = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, temp, Time.deltaTime);
            }
        }
    }
	void Update ()
    {
        //temp = new Vector3(maze.transform.position.x, transform.position.y, maze.transform.position.z);
        //transform.position = Vector3.Lerp(transform.position, temp, speed * Time.deltaTime);
        //transform.LookAt(maze.transform.position);
    }
}
