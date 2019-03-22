using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    public Rotator rotatorScript;
    public FearMeterScript fearScript;
    int health;

    public GameObject ImageOnPanel;  ///set this in the inspector
    public Texture NewTexture;
    public Texture NewTexture2;
    private RawImage img;
    private RawImage image;

    // Use this for initialization
    void Start ()
    {
        health = 3;
	}

    public void GetDamage()
    {
        health--;
       
        print("DAMAGED!!!");

        if (health == 2)
        {
            img = (RawImage)ImageOnPanel.GetComponent<RawImage>();
            img.texture = (Texture)NewTexture;
            print("Hurt!!!");
        }

        if (health == 1)
        {
            image = (RawImage)ImageOnPanel.GetComponent<RawImage>();
            image.texture = (Texture)NewTexture2;
            print("Dead!!!");
        }

        if (health == 0)
        {
            StartCoroutine("DelayedEndScreen");
        }
    }

    // Update is called once per frame
    void Update ()
    {
     /* if (health == 3f)
        {
          
        }

        if (health == 2f)
        {
            img = (RawImage)ImageOnPanel.GetComponent<RawImage>();
            img.texture = (Texture)NewTexture;
            print("Hurt!!!");
        }
        
        if (health == 1f)
        {
            image = (RawImage)ImageOnPanel.GetComponent<RawImage>();
            image.texture = (Texture)NewTexture2;
            print("Dead!!!");
        }

        if (health == 0f)
        {
            StartCoroutine("DelayedEndScreen");
        } */
	}

    IEnumerator DelayedEndScreen()
    {
        yield return new WaitForSeconds(.7f);
        Application.LoadLevel("GameOverScene");
        yield return null;
    }
}