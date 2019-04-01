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

    public Animator KidAnimator;

    // Use this for initialization
    void Start()
    {
    }
   
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, xMin, xMax), yValue, Mathf.Clamp(gameObject.transform.position.z, zMin, zMax));

        movementVelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.A) || Input.GetAxis("Horizontal1") < 0)
        {
            if (canMove)
            {
                movementVelocity.z = 1.0f;
                canMove = false;

                Invoke("CooledDown", coolDown);
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal1") > 0)
        {
            if (canMove)
            {
                movementVelocity.z = -1.0f * Time.deltaTime;
               canMove = false;

                Invoke("CooledDown", coolDown);
            }
        }

        if (Input.GetKey(KeyCode.W) || Input.GetAxis("Vertical1") > 0)
        {
            if (canMove)
            {
                //KidAnimator.SetTrigger("Walking");
                movementVelocity.x = 1.0f;
                canMove = false;

                Invoke("CooledDown", coolDown);
            }
        }

        if (Input.GetKey(KeyCode.S) || Input.GetAxis("Vertical1") < 0)
        {
            if (canMove)
            {
                movementVelocity.x = -1.0f;
                canMove = false;

                Invoke("CooledDown", coolDown);
            }
        }

        transform.Translate(movementVelocity.normalized * Time.deltaTime * movementSpeed, Space.World);
    }

    void CooledDown()
    {
        canMove = true;
    }
}