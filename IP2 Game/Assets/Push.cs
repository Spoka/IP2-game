using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{

    public GameObject CubeObject;

    public GameObject Cube2Object;
    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            CubeObject.SetActive(true);

        else if (Input.GetKeyUp(KeyCode.LeftShift))
            CubeObject.SetActive(false);
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
                Cube2Object.SetActive(false);

            else if (Input.GetKeyUp(KeyCode.LeftShift))
                Cube2Object.SetActive(true);

            if (Input.GetKeyUp(KeyCode.RightShift))
                CubeObject.SetActive(true);

            else if (Input.GetKeyDown(KeyCode.RightShift))
                CubeObject.SetActive(false);
            {
                if (Input.GetKeyUp(KeyCode.RightShift))
                    Cube2Object.SetActive(false);

                else if (Input.GetKeyDown(KeyCode.RightShift))
                    Cube2Object.SetActive(true);
            }

        }
    }
}
