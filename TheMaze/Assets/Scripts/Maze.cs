using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Maze : MonoBehaviour {

    public Transform start;
    public Transform end;
	// Use this for initialization
    Gyroscope gyro;
    Rigidbody rigi;
    float x, z = 0;
    float oldX, oldZ = 0;
    public float rotationRate;

    public Vector3 startpos;
    public Quaternion startrot;
    void Awake()
    {

        startpos = transform.position;
        startrot = transform.rotation;
    }
	public void Start ()
    {
        transform.position = startpos;
        transform.rotation = startrot;
        rigi = GetComponent<Rigidbody>();
        if(Input.gyro.enabled)
        {
            gyro = Input.gyro;	
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(gyro != null)
        transform.Rotate(gyro.rotationRateUnbiased.x, 0, gyro.rotationRateUnbiased.z);
        else
        {
           
            if(Input.GetKey(KeyCode.W))
            {
                x += rotationRate;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                x -= rotationRate;
            }
            if (Input.GetKey(KeyCode.A))
            {
                z += rotationRate;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                z -= rotationRate;
            }
            transform.Rotate(x,0,z);
            x = 0; z = 0;
        }
	}
    public void Rotate(float x)
    {
        transform.Rotate(0, x * rotationRate, 0);
    }

}

