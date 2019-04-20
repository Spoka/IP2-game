using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2MovementScript : MonoBehaviour {

    Vector3 up = new Vector3(0, 90, 0),
       right = new Vector3(0, 180, 0),
       down = new Vector3(0, 270, 0),
       left = Vector3.zero,
       currentDirection = new Vector3(0, 90, 0);
    Vector3 nextPos, destination, direction;

    public float speed = .75f;
    public float movementUnit = .75f;
    public Player2Script player2Script;

    bool canMove;

    public Animator animatorTeddy;

    void Start () {
        currentDirection = up;
        nextPos = Vector3.forward;
        destination = transform.position;
    }
	
	void Update () {
        Move();
	}

    void Move()
    {
        animatorTeddy.SetBool("Walk", false);
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetAxis("Vertical2") > 0)
        {
            nextPos = new Vector3(movementUnit, 0, 0);
            if(!player2Script.is2Parent)
            {
                currentDirection = up;
            }
            canMove = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Vertical2") < 0)
        {
            nextPos = new Vector3(-movementUnit, 0, 0);
            if(!player2Script.is2Parent)
            {
                currentDirection = down;
            }
            canMove = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetAxis("Horizontal2") > 0)
        {
            nextPos = new Vector3(0, 0, -movementUnit);
            if(!player2Script.is2Parent)
            {
                currentDirection = right;
            }
            canMove = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetAxis("Horizontal2") < 0)
        {
            nextPos = new Vector3(0, 0, movementUnit);
            if(!player2Script.is2Parent)
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
                animatorTeddy.SetBool("Walk", true);
                destination = transform.position + nextPos;
                direction = nextPos;
                canMove = false;
            }
        }
    }

    bool Valid()
    {
        Ray coolRay = new Ray(transform.position + new Vector3(0, 0.25f, 0), transform.forward);
        RaycastHit coolHit;
        Debug.DrawRay(coolRay.origin, coolRay.direction, Color.red);
        if (Physics.Raycast(coolRay, out coolHit, movementUnit))
        {
            if (coolHit.collider.tag == "Boundary")
            {
                return false;
            }
            if (coolHit.collider.tag == "Stuff" && player2Script.is2Parent == false)
            {
                return false;
            }
        }
        return true;
    }
}
