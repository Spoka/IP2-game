using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FearMeterScript : MonoBehaviour {

    // Use this for initialization
    public Slider fearBar;
    public float fear;
    private const float timeLapse = 10.0f;
    bool noLight = false;
    public GameObject PlayerCharacter1;
    Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.SetBool("LightCall", true);
        fear = 100f;
    }

    void Update()
    {
        if (fear <= 0f)
        {
            StartCoroutine("DelayedEndScreen");
        }
        if (noLight == true)
        {
            fear -= timeLapse * Time.deltaTime;
            fearBar.value = fear;
        }
        if (noLight == false && fear <= 100)
        {
            fear += timeLapse * Time.deltaTime * 2;
            fearBar.value = fear;
        }
        fearBar.value = fear;
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject == PlayerCharacter1)
        {
            noLight = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PlayerCharacter1)
        {
            noLight = false;
        }
    }

    public void StartLightCoroutine()
    {
        StartCoroutine("LightBackToFull");
    }

    IEnumerator LightBackToFull()
    {
        Anim.SetBool("LightCall", false);
        yield return new WaitForSeconds(.75f);
        Anim.SetBool("LightCall", true);
    }

    IEnumerator DelayedEndScreen()
    {
        yield return new WaitForSeconds(.7f);
        SceneManager.LoadScene("GameOverScene");
        yield return null;
    }
}
