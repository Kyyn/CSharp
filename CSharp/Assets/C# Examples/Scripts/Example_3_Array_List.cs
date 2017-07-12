using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_3_Array_List : MonoBehaviour
{

    public string[] playerNames = new string[3];
    public List<string> enemyNames = new List<string>();

	// Use this for initialization
	void Start ()
    {
        playerNames[0] = "John";
        playerNames[1] = "Jane";
        playerNames[2] = "Bob";

        enemyNames.Add("Boss");
        enemyNames.Add("Big_Boss");
        enemyNames.Add("Bigger_Boss");

        Debug.Log("Player Name is: " + playerNames[1] + " and boss is " + enemyNames[2]);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
