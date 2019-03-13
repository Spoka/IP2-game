using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour {

    public PlayerScript playerScript;
    public Player2Script player2Script;
    public GameObject rotationWarning;
    public float rotationAngle = 90f;
    public float rotationStart = 0f;
    public float autoRotationTimer;
    float rT = 0;
    public bool isRotating = false;

    //When player1 stands on a section for 2 or more seconds, start rotation coroutine 
    private void OnTriggerStay (Collider other)
    {
        if (other.tag == "Player2")
        {
            rT += Time.deltaTime;
            if (rT >= autoRotationTimer)
            {
                rotationWarning.SetActive(true);
                StartCoroutine(NiceRotation(rotationStart, rotationAngle, 1.0f));
                rT = 0;
            }
        }
    }

    //Child Stuff object to the section it's in
    private void OnTriggerEnter(Collider other)
    {
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
        if (other.tag == "Player2")
        {
            if (rT <= 1.5f)
            {
                rT = 0;
            }
        }
    }

    public void CubePieceRotation()
    {
        StartCoroutine(NiceRotation(rotationStart, rotationAngle, 1.0f));
    }
  

    //Rotation coroutine --- Lerp the section, show rotation warning, call method that updates lerp values
    IEnumerator  NiceRotation(float start, float end, float maxTime)
    {
        float t = 0;
        yield return new WaitForSeconds(1);
        isRotating = true;

        while (t < maxTime)
        {
            t += Time.deltaTime*2;
            //print("called");
            Quaternion rot = GetComponent<Transform>().rotation;
            
            rot.x = Mathf.Lerp(start, end, t*t);

            transform.SetPositionAndRotation(transform.position, Quaternion.Euler(rot.x, rot.y, rot.z));

            if(t >= maxTime)
            {
                rot.x = end;
            }
            yield return null;
        }
        rotationWarning.SetActive(false);
        NewRotValues();
        isRotating = false;
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
