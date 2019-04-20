using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour {

    public bool imageActive;
    public RawImage img;

    void Start()
    {

        img.enabled = true;
      
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.I) || Input.GetKey(KeyCode.JoystickButton3))
        {
         
            {
                Time.timeScale = 0;
                img.enabled = true;
             
               
            }
        }
        else
        {
            Time.timeScale = 1;
            img.enabled = false;
         

            
        }
   
    }
}


