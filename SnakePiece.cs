using UnityEngine;
using System.Collections;

/// <summary>
/// This script is attached to each snake piece, i.e., to the Snake Prefab.
/// It will be used to update the position of the snake, in theory utilising the input from the game controller
/// 
/// This script accesses the SnakeManager script SnakeScript
/// </summary>

public class SnakePiece : MonoBehaviour {

	// Variables start__________________

	// Quick references
	private int snakeNumber;
	private Transform myTransform;

	// This variable states if there has been a collision
	public bool iAteFood = false;

	// Variables end____________________

	// Use this for initialization
	void Start () 
	{
		// Simple transform setting
		myTransform = transform;

		// Set the ID number of this snake head using the snake manager
		GameObject snakeManager = GameObject.Find("SnakeManager");
		SnakeScript sScript = snakeManager.GetComponent<SnakeScript>();
		sScript.numberOfSnakes += 1;
		snakeNumber  = sScript.numberOfSnakes;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// If the snake piece is the snake head, then check if it collided with a piece of food
		if(snakeNumber == 1)
		{
			// Check if I interact with an object that has a tag of "food"
		}
	}
}
