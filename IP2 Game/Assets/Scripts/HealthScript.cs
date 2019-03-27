using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    public Rotator rotatorScript;
    public FearMeterScript fearScript;
    int health;

    public GameObject ImageOnPanel;  //set this in the inspector
    public Texture NewTexture;
    public Texture NewTexture2;
    public Texture NewTexture3;
    private RawImage img;
    private RawImage image;

    public AudioSource kidOof;

    // Use this for initialization
    void Start ()
    {
        health = 3;
	}

    public void GetDamage()
    {
        health--;
       
        print("DAMAGED!!!");

        kidOof.Play(0);

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
            image = (RawImage)ImageOnPanel.GetComponent<RawImage>();
            image.texture = (Texture)NewTexture3;
            StartCoroutine("DelayedEndScreen");
        }
    }

    // Update is called once per frame
    void Update ()
    {
     
	}

    IEnumerator DelayedEndScreen()
    {
        yield return new WaitForSeconds(.7f);
        Application.LoadLevel("GameOverScene");
        yield return null;
    }
}