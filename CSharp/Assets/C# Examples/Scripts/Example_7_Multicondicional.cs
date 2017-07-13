using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_7_Multicondicional : MonoBehaviour
{

    public int lives = 3;
    public bool canAddLives = false;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if ( lives > 0 && canAddLives)
        {
            Debug.Log("Extra lives");
        }

        if (lives <= 0 || canAddLives)
        {
            Debug.Log("No lives left, but can add Lives");
        }
	}
}
