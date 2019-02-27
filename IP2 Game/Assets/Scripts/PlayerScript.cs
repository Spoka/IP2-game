using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

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
