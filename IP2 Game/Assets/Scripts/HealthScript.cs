using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour {

    public FearMeterScript fearScript;
    int health;

    public GameObject ImageOnPanel;  //set this in the inspector
    public Texture NewTexture;
    public Texture NewTexture2;
    public Texture NewTexture3;
    private RawImage img;
    private RawImage image;

    AudioSource kidOof;

    // Use this for initialization
    void Start ()
    {
        health = 3;
        kidOof = GetComponent<AudioSource>();
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

    IEnumerator DelayedEndScreen()
    {
        yield return new WaitForSeconds(.7f);
        SceneManager.LoadScene("GameOverScene");
        yield return null;
    }
}