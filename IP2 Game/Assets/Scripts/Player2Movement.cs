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

    public Animator bearAnimator;

    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, xMin, xMax), yValue, Mathf.Clamp(gameObject.transform.position.z, zMin, zMax));
        movementVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetAxis("Vertical2") > 0)
        {
            if (canMove)
            {
                bearAnimator.SetTrigger("Walking");
                movementVelocity.x = 1.0f;
                
                canMove = false;
                bearAnimator.SetTrigger("NotWalking");
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
    }

    void CooledDown()
    {
        canMove = true;
    }
}
