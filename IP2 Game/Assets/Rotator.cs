using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour {

    //public float rotationTime = 0.5f;
    //public float rotationAgle = 90f;

    public void CubePieceRotation()
    {
        StartCoroutine(NiceRotation(0f, 90f, 1.0f));
    }
  
    IEnumerator  NiceRotation(float start, float end, float maxTime)
    {
        float t = 0;
        while (t < maxTime)
        {
            t += Time.deltaTime*2;
            print("called");
            Quaternion rot = GetComponent<Transform>().rotation;
            
            rot.x = Mathf.Lerp(start, end, t);

            transform.SetPositionAndRotation(transform.position, Quaternion.Euler(rot.x, rot.y, rot.z));

            if(t >= maxTime)
            {
                rot.x = end;
            }
            yield return null;
        }
    }
    
    
    /*  public void CubePieceRotation()
        {
            if (gameObject.tag == "CubePiece")
            {
                Quaternion target = Quaternion.Euler(90, 0, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationTime);
            }
        }
        
    */
}
