using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour {

    public bool is2Parent = false;

    public GameObject teddyParent;

    public AudioSource audioRotWarning;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stuff")
        {
            if (is2Parent == false)
            {
                if (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.Joystick2Button2))
                {
                    other.transform.SetParent(teddyParent.transform);
                    is2Parent = true;
                }
            }
            else if (is2Parent == true)
            {
                if (Input.GetKeyDown(KeyCode.RightControl) || Input.GetKeyDown(KeyCode.Joystick2Button1))
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
