using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour {

    public GameObject maze;
    public float speed;
    Vector3 temp;

	void Update ()
    {
        temp = Vector3.Lerp(transform.position, maze.transform.position, speed * Time.deltaTime);
        transform.position = new Vector3(temp.x, transform.position.y, temp.z);
        transform.LookAt(maze.transform);
    }
}
