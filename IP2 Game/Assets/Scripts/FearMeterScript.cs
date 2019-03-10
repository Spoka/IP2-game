using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearMeterScript : MonoBehaviour {

    // Use this for initialization
    public LifeLoss other;

    public Slider fearBar;
    public static float fear;
    float t = 10f;

    void Start()
    {
        fear = 100f;
    }

    void Update()
    {
        fearBar.value = fear;
    if (fear == 0f)
        {
            other.LoseHealth();
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            fear = fear - t / Time.deltaTime;
        }
    }


    
    
}
