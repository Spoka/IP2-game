using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    public Rotator rotatorScript;
    public FearMeterScript fearScript;
    int health;

	// Use this for initialization
	void Start () {
        health = 3;
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "CubePiece")
        {
            if (rotatorScript.isRotating == true)
            {
                health--;
                print("DAMAGE!!!");
                rotatorScript.isRotating = false;
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
