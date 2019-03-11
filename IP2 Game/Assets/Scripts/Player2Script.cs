using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour {
    public bool isParent = false;
    // Use this for initialization
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stuff")
        {
            if (isParent == false)
            {
                if (Input.GetKey(KeyCode.P))
                {
                    other.transform.SetParent(gameObject.transform);
                    isParent = true;
                }
            }
            else if (isParent == true)
            {
                if (Input.GetKey(KeyCode.O))
                {
                    other.transform.parent = null;
                    isParent = false;
                }
            }
        }
    }
}
