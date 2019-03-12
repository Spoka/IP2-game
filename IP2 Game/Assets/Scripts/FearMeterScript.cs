using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearMeterScript : MonoBehaviour {

    // Use this for initialization
    public LifeLoss other;

    public Slider fearBar;
    public float fear;
    private const float timeLapse = 0.5f;
    float lT;

    void Start()
    {
        lT = 0;
        fear = 100f;
    }

    void Update()
    {
        fearBar.value = fear;
    if (fear == 0f)
        {
            other.LoseHealth();
        }

       // fear -= timeLapse * Time.deltaTime;

    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            //fear = fear - lT / Time.deltaTime;
            //fear -= timeLapse * Time.deltaTime;
            lT += Time.deltaTime;
            if (lT >= 2.5f)
            {
                fear = 0;
            }
        }

        if(fear == 50)
        {
            print("fear to 50");
        }
    }
}
