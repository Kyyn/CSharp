using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_2_Variables : MonoBehaviour
{
    public string playerName = "Player Name";
    [Range (0, 100)] public int playerHealth = 100;
    private float playerSpeed = 5.0f;
    [HideInInspector] public bool isDead = false;





	// Use this for initialization
	void Start ()
    {
        Debug.Log(playerName + " " + playerHealth + " " + playerSpeed + " " + isDead);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
