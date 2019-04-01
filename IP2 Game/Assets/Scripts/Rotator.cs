using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour {

    public PlayerScript playerScript;
    public Player2Script player2Script;
    public HealthScript healthScript;
    public WarnimationScript warningAnimation;

    public GameObject rotationWarning;

    float rotationAngle = 90f;
    float rotationStart = 0f;
    public float autoRotationTimer;
    float rT = 0;
    public bool isRotating = false;

    //When player1 stands on a section for () or more seconds, start rotation coroutine 
    private void OnTriggerStay (Collider other)
    {
        if (other.tag == "Player")
        {
            rT += Time.deltaTime;
            if (rT >= autoRotationTimer)
            {
                //print("called" + rT);
                //rotationWarning.SetActive(true);
                StartCoroutine(NiceRotation(rotationStart, rotationAngle, 1.0f));
                //StartCoroutine("DelayedWarn");
                warningAnimation.rotAnimation();
                player2Script.audioRotWarning.Play(0);
                rT = 0;
            }
        }
        if (other.tag == "Player"/* || other.tag == "Player2"*/)
        {
            if (isRotating == true)
            {
                healthScript.GetDamage();
                isRotating = false;
            }
        }
        //Child Stuff object to the section it's in
        if (other.tag == "Stuff")
        {
            if (playerScript.isParent == false && player2Script.is2Parent == false)
            {
                other.transform.SetParent(gameObject.transform);
            }
        }
    }

    //Reset rotation timer if player1 exits the section
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (rT <= autoRotationTimer)
            {
                rT = 0;
            }
        }
    }

    //Public method to call the rotation from outside the script, should be unused in the final state of the game
    public void CubeRotation()
    {
        StartCoroutine(NiceRotation(rotationStart, rotationAngle, 1.0f));
    }

    //Rotation coroutine --- Lerp the section, show rotation warning, call method that updates lerp values
    IEnumerator  NiceRotation(float start, float end, float maxTime)
    {
        //print("called" + rT);
        float t = 0;
        yield return new WaitForSeconds(1.5f);
        isRotating = true;
        
        while (t < maxTime)
        {
            t += Time.deltaTime;
            
            Quaternion rot = GetComponent<Transform>().rotation;
            
            rot.x = Mathf.Lerp(start, end, t*t);

            transform.SetPositionAndRotation(transform.position, Quaternion.Euler(rot.x, rot.y, rot.z));

            if(t >= maxTime)
            {
                rot.x = end;
                isRotating = false;
                //rT = 0;
            }
            yield return null;
        }
        //isRotating = false;
        rotationWarning.SetActive(false);
        NewRotValues();
    }

    //Update lerp values
    public void NewRotValues()
    {
        if (rotationAngle != 0)
        {
            rotationStart = rotationAngle;
            rotationAngle += 90f;
        }
    }
}
