using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1MovementScript : MonoBehaviour
{
    Vector3 up = new Vector3(0, 90, 0),
        right = new Vector3(0, 180, 0),
        down = new Vector3(0, 270, 0),
        left = Vector3.zero,
        currentDirection = new Vector3(0, 90, 0);
    Vector3 nextPos, destination, direction;

    Vector3 rayDirection;

    public float speed = .75f;
    public float movementUnit = .75f;
    float rayDistance;
    public PlayerScript playerScript;

    bool canMove;

    public Animator animatorKid;

    void Start()
    {
        currentDirection = up;
        nextPos = Vector3.forward;
        destination = transform.position;
        rayDistance = movementUnit;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        animatorKid.SetBool("Walk", false);
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) || Input.GetAxis("Vertical1") > 0)
        {
            nextPos = new Vector3(movementUnit, 0, 0);
            if(!playerScript.isParent)
            {
                currentDirection = up;
            }
            canMove = true;
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetAxis("Vertical1") < 0)
        {
            nextPos = new Vector3(-movementUnit, 0, 0);
            if(!playerScript.isParent)
            {
                currentDirection = down;
            }
            canMove = true;
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetAxis("Horizontal1") < 0)
        {
            nextPos = new Vector3(0, 0, -movementUnit);
            if(!playerScript.isParent)
            {
                currentDirection = right;
            }
            canMove = true;
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetAxis("Horizontal1") > 0)
        {
            nextPos = new Vector3(0, 0, movementUnit);
            if(!playerScript.isParent)
            {
                currentDirection = left;
            }
            canMove = true;
        }

        if (Vector3.Distance(destination, transform.position) <= 0.00001f)
        {
            transform.localEulerAngles = currentDirection;
            if (canMove && Valid())
            {
                animatorKid.SetBool("Walk", true);
                destination = transform.position + nextPos;
                direction = nextPos;
                canMove = false;
            }
        }
    }

    bool Valid()
    {
        Ray coolRay = new Ray(transform.position + new Vector3(0, 0.25f, 0), nextPos);
        RaycastHit coolHit;
        Debug.DrawRay(coolRay.origin, coolRay.direction, Color.cyan);
        if(Physics.Raycast(coolRay, out coolHit, rayDistance))
        {
            if(coolHit.collider.tag == "Boundary")
            {
                return false;
            }
            if(coolHit.collider.tag == "Stuff" && playerScript.isParent == false)
            {
                return false;
            }
        }
        return true;
    }
}