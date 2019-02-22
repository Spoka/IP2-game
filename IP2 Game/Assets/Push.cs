using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public Rigidbody rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void EnableRagdoll()
    {
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }
    void DisableRagdoll()
    {
        rb.isKinematic = true;
        rb.detectCollisions = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && (Input.GetKey(KeyCode.LeftShift)))
        {
            EnableRagdoll();
        }
        else if(collision.gameObject.tag == "Player2" && (Input.GetKey(KeyCode.RightShift)))
        {
            EnableRagdoll();
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DisableRagdoll();
        }
        else if (collision.gameObject.tag == "Player2")
        {
            DisableRagdoll();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
    }
    }

