using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeLoss : MonoBehaviour
{
    public GameObject ImageOnPanel;  ///set this in the inspector
    public Texture NewTexture;
    private RawImage img;

    void Start()

    {
       
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {

            img = (RawImage)ImageOnPanel.GetComponent<RawImage>();

            img.texture = (Texture)NewTexture;
        }
    }
}
