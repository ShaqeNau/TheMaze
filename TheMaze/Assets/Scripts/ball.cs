using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    Game game;
    public Maze maze;
	// Use this for initialization
	public void Start ()
    {
        game = FindObjectOfType<Game>();
        transform.position = maze.start.position;
        GetComponent<Rigidbody>().AddForce(Vector3.zero, ForceMode.VelocityChange);
	}


    void OnTriggerEnter()
    {
        game.Win();
    }
}
