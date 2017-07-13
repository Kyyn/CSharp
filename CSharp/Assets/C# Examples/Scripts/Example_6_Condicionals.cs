using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_6_Condicionals : MonoBehaviour
{
    public bool gameOver = false;
    public bool hasWon = false;
    public bool hasLost = false;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if ( gameOver == true) // if (gameOver)
        {

            Debug.Log("Game Over");
        }
        else
        {
            Debug.Log("Game is playing.");
            if (hasWon) Debug.Log("Player Won");
            else if (hasLost) Debug.Log("Player Lost");

        }



	}
}
