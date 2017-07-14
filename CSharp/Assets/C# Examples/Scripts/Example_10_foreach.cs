using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_10_foreach : MonoBehaviour 
{

    string[] friends = new string[] { "john", "sue", "brad" };
	// Use this for initialization
	void Start () 
	{
		foreach (string friend in friends)
        {
            Debug.Log("Names of friends: " + friend);
        }
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
