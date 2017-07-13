using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_8_Switch_Case : MonoBehaviour
{
    public int playerId = 0;
    public enum PlayerTeam { none, blue, red, green, black };
    public PlayerTeam playerTeam = PlayerTeam.none;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		switch (playerId)
        {
            case 0:
                Debug.Log ("0 ");
                Debug.Log("intento");
                break;
            case 1:Debug.Log ("1 ");    break;
            case 2:Debug.Log ("2 ");    break;
            case 3:Debug.Log("3 ");     break;

        }

        switch (playerTeam)
        {
            case PlayerTeam.black:   Debug.Log("black");    break;
            case PlayerTeam.blue:    Debug.Log("blue");     break;
            case PlayerTeam.red:     Debug.Log("red");      break;
            case PlayerTeam.green:   Debug.Log("green");    break;
            case PlayerTeam.none:    Debug.Log("none");     break;
            default:                 Debug.Log("Nadie");    break;


        }


	}
}
