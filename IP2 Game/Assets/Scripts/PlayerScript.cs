using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    //this bool's purpose is mainly to be checked by the rotator script
    //and make sure that the Stuff object is not childed to a section 
    //while being grabbed by the player

    public bool isParent = false;
    public GameObject kidParent;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stuff")
        {
            if (isParent == false)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.Joystick1Button2))
                {
                    other.transform.SetParent(kidParent.transform);
                    isParent = true;
                }
            }
            if (isParent == true)
            {
                if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.Joystick1Button1))
                {
                    other.transform.parent = null;
                    isParent = false;
                }
            }
        }
    }
}