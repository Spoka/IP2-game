using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    

    public float movementSpeed;
    Vector3 movementVelocity;


    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        movementVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movementVelocity.z = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementVelocity.z = -1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementVelocity.x = 1.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementVelocity.x = -1.0f;
        }
        transform.Translate(movementVelocity.normalized * Time.deltaTime * movementSpeed, Space.World);

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0.0f, 200 * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0.0f, -200 * Time.deltaTime, 0.0f);
        }
    }
}