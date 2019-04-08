using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimController : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.R))
        {
            animator.SetTrigger("Walk");
        }
        if (Input.GetKey(KeyCode.T))
        {
            animator.SetTrigger("Forward");
            animator.SetLookAtPosition(transform.position);
        }
	}
}
