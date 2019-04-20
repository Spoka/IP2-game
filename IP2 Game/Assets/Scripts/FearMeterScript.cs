using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        Anim.SetTrigger("Call");
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
            fear += timeLapse * Time.deltaTime *2;
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

    IEnumerator DelayedEndScreen()
    {
        yield return new WaitForSeconds(.7f);
        Application.LoadLevel("GameOverScene");
        yield return null;
    }
}
