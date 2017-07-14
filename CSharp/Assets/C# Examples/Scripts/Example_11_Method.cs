using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_11_Method : MonoBehaviour 
{
    public string message = "This is our message";

	// Use this for initialization
	void Start () 
	{
        Message();
        Message("Hi");
        Message(message, 3);

        float total = AddValues(10f, 3.5f);
        Debug.Log("Total is: " + total);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

    void Message()
    {
        Debug.Log("Empty arguments");
    }
    void Message(string message)
    {
        Debug.Log("Just Message: " + message);
    }
    void Message(string message, int id)
    {
        Debug.Log(message + " id: " + id);

        Debug.Log("this" + this.message); // references the global public variable at the begining of the script.
    }

    float AddValues (float a, float b)
    {
        return a + b;
    }
    
}
