using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour {

    bool canMove = true;

    public float coolDown = 0.15f;

    public float movementSpeed;
    Vector3 movementVelocity;

    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;
    public float yValue;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, xMin, xMax), yValue, Mathf.Clamp(gameObject.transform.position.z, zMin, zMax));
        movementVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetAxis("Vertical2") > 0)
        {
            if (canMove)
            {
                movementVelocity.x = 1.0f;
                canMove = false;

                Invoke("CooledDown", coolDown);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetAxis("Vertical2") < 0)
        {
            if (canMove)
            {
                movementVelocity.x = -1.0f;
                canMove = false;

                Invoke("CooledDown", coolDown);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetAxis("Horizontal2") > 0)
        {
            if (canMove)
            {
                movementVelocity.z = -1.0f;
                canMove = false;

                Invoke("CooledDown", coolDown);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetAxis("Horizontal2") < 0)
        {
            if (canMove)
            {
                movementVelocity.z = 1.0f;
                canMove = false;

                Invoke("CooledDown", coolDown);
            }
        }
        transform.Translate(movementVelocity.normalized * Time.deltaTime * movementSpeed, Space.World);

      /*  if (Input.GetKey(KeyCode.M))
        {
            transform.Rotate(0.0f, 200 * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.N))
        {
            transform.Rotate(0.0f, -200 * Time.deltaTime, 0.0f);
        }*/
    }

    void CooledDown()
    {
        canMove = true;
    }
}
