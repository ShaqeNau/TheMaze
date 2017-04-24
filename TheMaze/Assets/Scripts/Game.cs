using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public Text winText;
    public ball ball1;
    public Maze maze;
	// Use this for initialization
	void Start ()
    {
        winText.GetComponent<Text>().enabled = false;
    }
	
    public void Win()
    {
        Debug.Log("WIN");
        winText.GetComponent<Text>().enabled = true;
    }
    public void Restart()
    {
        Debug.Log("RESTART");
        maze.Start();
        ball1.Start();
        winText.GetComponent<Text>().enabled = false;
    }
    public void ExitGame()
    {
        Debug.Log("QUIT APPLICATION");
        Application.Quit();
    }
}
