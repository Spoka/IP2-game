using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearMeterScript : MonoBehaviour {

    // Use this for initialization
    public LifeLoss other;
    bool isOutside = false;
    public Slider fearBar;
    public float fear;

    private const float timeLapse = 2.0f;


    void Start()
    {
        fear = 100f;
    }

    void Update()
    {
        
    if (fear == 0f)
        {
            other.LoseHealth();
        }


        fear -= timeLapse * Time.deltaTime;


        if (isOutside == true)
        {
            fearBar.value = fear;
            fear -= timeLapse * Time.deltaTime;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {

            //fear = fear - lT / Time.deltaTime;
            fear -= timeLapse * Time.deltaTime;

            isOutside = true;
            print("fear working");

        }

        if(fear == 50)
        {
            print("fear to 50");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isOutside = false;
            print("is working fine");
        }
    }
}
