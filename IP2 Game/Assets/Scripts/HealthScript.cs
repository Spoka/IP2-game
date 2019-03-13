using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    public Rotator rotatorScript;
    public FearMeterScript fearScript;
    int health;

	// Use this for initialization
	void Start ()
    {
        health = 3;
	}

    public void GetDamage()
    {
        health--;
        //rotatorScript.isRotating = false;
        print("DAMGED!!!");
    }
   

    // Update is called once per frame
    void Update () {
		
	}
}
