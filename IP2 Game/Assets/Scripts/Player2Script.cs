using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour {

    public bool is2Parent = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stuff")
        {
            if (is2Parent == false)
            {
                if (Input.GetKey(KeyCode.RightShift))
                {
                    other.transform.SetParent(gameObject.transform);
                    is2Parent = true;
                }
            }
            else if (is2Parent == true)
            {
                if (Input.GetKey(KeyCode.RightControl))
                {
                    other.transform.parent = null;
                    is2Parent = false;
                }
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
