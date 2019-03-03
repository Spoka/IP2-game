using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    //this bool's purpose is mainly to be checked by the rotator script
    //and make sure that the Stuff object is not childed to a section 
    //while being grabbed by the player
    public bool isParent = false;

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

}
