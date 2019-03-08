using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour {

    public float movementSpeed;
    Vector3 movementVelocity;


    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        movementVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementVelocity.x = 1.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementVelocity.x = -1.0f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementVelocity.z = -1.0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementVelocity.z = 1.0f;
        }
        transform.Translate(movementVelocity.normalized * Time.deltaTime * movementSpeed, Space.World);

        if (Input.GetKey(KeyCode.M))
        {
            transform.Rotate(0.0f, 200 * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.N))
        {
            transform.Rotate(0.0f, -200 * Time.deltaTime, 0.0f);
        }
    }
}
