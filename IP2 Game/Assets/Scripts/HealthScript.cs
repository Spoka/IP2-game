using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    public Rotator rotatorScript;
    public FearMeterScript fearScript;
    public GameObject healthIcon3;
    public GameObject healthIcon2;
    public GameObject healthIcon1;
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
    void Update ()
    {
		if (health == 3)
        {
            healthIcon3.SetActive(true);
            healthIcon2.SetActive(false);
            healthIcon1.SetActive(false);
        }
        else if (health == 2)
        {
            healthIcon3.SetActive(false);
            healthIcon2.SetActive(true);
            healthIcon1.SetActive(false);
        }
        else if (health == 1)
        {
            healthIcon3.SetActive(false);
            healthIcon2.SetActive(false);
            healthIcon1.SetActive(true);
        }
	}
}
