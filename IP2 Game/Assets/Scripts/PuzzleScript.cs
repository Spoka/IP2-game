using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour {

    public PlayerScript playerScript;
    public Player2Script player2Script;
    // Use this for initialization
    void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Stuff")
        {
            if (playerScript.isParent == true || player2Script.is2Parent == true)
            {
                other.transform.SetParent(gameObject.transform);
            }
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
