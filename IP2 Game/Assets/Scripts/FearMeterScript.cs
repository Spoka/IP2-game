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

    void Start()
    {
        fear = 100f;
    }

    void Update()
    {
        fearBar.value = fear;
        if (fear <= 0f)
        {
           StartCoroutine("DelayedEndScreen");
        }
        if (noLight == true)
        {
            fear -= timeLapse * Time.deltaTime;
            fearBar.value = fear;
        }
        if (noLight == false)
        {
            fear += timeLapse * Time.deltaTime;
            fearBar.value = fear;
        }
    }

  

    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            //fear = fear - lT / Time.deltaTime;
            //fear -= timeLapse * Time.deltaTime;
            noLight = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
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
