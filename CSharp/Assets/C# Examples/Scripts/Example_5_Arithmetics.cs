using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_5_Arithmetics : MonoBehaviour
{

    int ammo = 100;
    int ammoPickup = 10;
    int ammoPickupDouble = 2;
    int ammoPickupReduce = 10;

	// Use this for initialization
	void Start ()
    {
        int total = ammo + ammoPickup;

        total = total + ammo;  // total += ammo;

        total = total * ammoPickupDouble;  // total *= ammoPickupDouble;

        total = total / ammoPickupReduce;  // total /= ammoPickupReduce;

        total = total + 1;  //  total++; (++total; indicates operatin is done before any other action)
        total = total - 1;   //  total--; --ammo;

        Debug.Log("Ammo: " + total);
	}

    // Update is called once per frame
    void Update()
    {
		
	}
}
