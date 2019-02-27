using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour {

    public PlayerScript playerScript;
    public float rotationAngle = 90f;
    public float rotationStart = 0f;
    public float autoRotationTimer = 3.0f;
    float rT = 0;

    private void OnTriggerStay (Collider other)
    {
        if (other.tag == "Player" || other.tag == "Player2")
        {
            rT += Time.deltaTime;
            if (rT >= autoRotationTimer)
            {
                print("we fratm");
                StartCoroutine(NiceRotation(rotationStart, rotationAngle, 1.0f));
                rT = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Stuff")
        {
            if (playerScript.isParent == false)
            {
                print("suca");
                other.transform.SetParent(gameObject.transform);
            }           
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Player2")
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
  
    IEnumerator  NiceRotation(float start, float end, float maxTime)
    {
        float t = 0;
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
        NewRotValues();
    }

    public void NewRotValues()
    {
        if (rotationAngle != 0)
        {
            rotationStart = rotationAngle;
            rotationAngle += 90f;
        }
    }
}
