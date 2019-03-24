using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1Movement : MonoBehaviour
{
    public float speed;

    bool canMove = true;

    public float coolDown = 0.15f;

    public float movementSpeed;
    Vector3 movementVelocity;

    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;
    public float yValue;


    // Use this for initialization
    void Start()
    {
    }
   
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, xMin, xMax), yValue, Mathf.Clamp(gameObject.transform.position.z, zMin, zMax));

        movementVelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.A) && canMove)
        {
            movementVelocity.z = ++movementVelocity.z;
            canMove = false;

           Invoke("CooledDown", coolDown);
        }
        if (Input.GetKey(KeyCode.D) && canMove)
        {
            movementVelocity.z = -1.0f;
            canMove = false;

            Invoke("CooledDown", coolDown);
        }
        if (Input.GetKey(KeyCode.W) && canMove)
        {
          
            movementVelocity.x = 1.0f;
           
            canMove = false;

            Invoke("CooledDown", coolDown);
        }
        if (Input.GetKey(KeyCode.S) && canMove)
        {
            movementVelocity.x = -1.0f;
            canMove = false;

            Invoke("CooledDown", coolDown);
        }

        if (Input.GetKey(KeyCode.H)&& canMove)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            canMove = false;

            Invoke("CooledDown", coolDown);
        }
        transform.Translate(movementVelocity.normalized * Time.deltaTime * movementSpeed, Space.World);

       /* if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0.0f, 200 * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0.0f, -200 * Time.deltaTime, 0.0f);
        }*/
    }

    void CooledDown()
    {
        canMove = true;
    }
}