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
    public GameObject gyrotext;
    Quaternion initialQuat;
    Quaternion attitudeFix;
    Quaternion attitudeRel;

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

        Input.gyro.enabled = true;
        gyro = Input.gyro;
        initialQuat = Input.gyro.attitude;
	}
    void FixedUpdate ()
    {
        attitudeRel = Input.gyro.attitude;// * initialQuat;
        attitudeFix = new Quaternion(attitudeRel.x, attitudeRel.z, attitudeRel.y, -attitudeRel.w);
        transform.rotation = attitudeFix;

        gyrotext.GetComponent<Text>().enabled = true;
        gyrotext.GetComponent<Text>().text = attitudeFix.ToString();
    }
}

