using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovementScript : MonoBehaviour
{
    /*

	// Use this for initialization
	void Start () {
        Start_Pos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.H))
        {
            End_Pos = transform.position + new Vector3(0, 0, 5);
            Move += 0.01f;
            transform.position = Vector3.Lerp(Start_Pos, End_Pos, Move);
        }
	}
}
*/

    public float speed;

    void Start()
    {


    }
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }

}