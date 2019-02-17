using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour {

    public float rotationTime = 0.5f;
    public float rotationAgle = 90f;

    public void CubePieceRotation()
    {
        if(gameObject.tag == "CubePiece")
        {
            Quaternion target = Quaternion.Euler(90, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationTime);
        }
    }

}
