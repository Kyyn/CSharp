﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_9_Loops : MonoBehaviour
{

    public int counterMax = 10;

	// Use this for initialization
	void Start ()
    {
        
        for (int i = 0; i <= counterMax; i++)
        {
            Debug.Log("Counting: " + i);

            if ( i == 3)
            {
                Debug.Log("Current 3");
            }


        }
        

        
        int j = 0;
        while ( j < 10)
        {
            Debug.Log("Count while: " + j);
            j++;
        }
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
