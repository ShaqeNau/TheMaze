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
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter()
    {
        game.Win();
    }
}
