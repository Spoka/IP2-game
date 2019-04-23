using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuloader : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        StartCoroutine("DelayMenu");
    }

    IEnumerator DelayMenu()
    {
        yield return new WaitForSeconds(75);
        Application.LoadLevel("MenuScene");
    }
}
