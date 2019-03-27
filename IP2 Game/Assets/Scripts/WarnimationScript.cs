using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnimationScript : MonoBehaviour {

    public Animator warningAnim;

	// Use this for initialization
	void Start ()
    {
        warningAnim = GetComponent<Animator>();
    }
	
    public void rotAnimation()
    {
        warningAnim.SetTrigger("Warning");
    }
    
   /* IEnumerator DelayedWarn()
    {
        yield return new WaitForSeconds(1.5f);
        warningAnim.Play("WarningShake");
        yield return null;
    }*/

	// Update is called once per frame
	void Update () {
		
	}
}
