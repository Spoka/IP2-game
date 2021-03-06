﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    //this bool's purpose is mainly to be checked by the rotator script
    //and make sure that the Stuff object is not childed to a section 
    //while being grabbed by the player
    public bool isParent = false;
	public Rotator Section1;
	public Rotator Section2;
	public Rotator Section3;
	public Rotator Section4;
	public Rotator Section5;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stuff")
        {
            if (isParent == false)
            { 
                if (Input.GetKey(KeyCode.Space))
                {
                    other.transform.SetParent(gameObject.transform);
                    isParent = true;
                }
            }
            else if (isParent == true)
            {
                if (Input.GetKey(KeyCode.LeftControl))
                {
                    other.transform.parent = null;
                    isParent = false;
                }
            } 
        }
    }
	
	void Update()
	{
		if (Input.GetKey(KeyCode.Alpha1))
		{
			Section1.CubePieceRotation();
		}
		if (Input.GetKey(KeyCode.Alpha2))
		{
			Section2.CubePieceRotation();
		}
		if (Input.GetKey(KeyCode.Alpha3))
		{
			Section3.CubePieceRotation();
		}
		if (Input.GetKey(KeyCode.Alpha4))
		{
			Section4.CubePieceRotation();
		}
		if (Input.GetKey(KeyCode.Alpha5))
		{
			Section5.CubePieceRotation();
		}
	}
}
