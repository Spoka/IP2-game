using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour {

    // Use this for initialization
    // Transforms to act as start and end markers for the journey.
    int distance = 50;
    bool canMove = true;

    public float coolDown = 0.15f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (canMove)
            {
                transform.Translate(Vector3.forward * distance * Time.deltaTime );
               
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))

        {
            transform.Translate(-Vector3.forward * Time.deltaTime * distance);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))


        {
            transform.Translate(Vector3.right * Time.deltaTime * distance);

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))

        {
            transform.Translate(-Vector3.right * Time.deltaTime * distance);
        }
    }

}
