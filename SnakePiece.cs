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
	private float range = 1;
	private RaycastHit hit;
	public bool iAteFood = false;
	private Collision colHit;

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

	void OnCollisionEnter(Collision collision)
	{
		// Check it is the snake head colliding
		if(snakeNumber == 1 && collision.gameObject.tag == "Food")
		{
			// Tell the snake manager it must make a new snake piece
			GameObject snakeManager = GameObject.Find("SnakeManager");
			SnakeScript sScript = snakeManager.GetComponent<SnakeScript>();
			sScript.makeNewSnake = true;
		}
		
		// Tell the food manager to destroy the current food and make some new food
	}

	
	// Update is called once per frame
	void Update () 
	{
	}
}
