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

        fear -= timeLapse * Time.deltaTime;

    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            //fear = fear - lT / Time.deltaTime;
            fear -= timeLapse * Time.deltaTime;
        }

        if(fear == 50)
        {
            print("fear to 50");
        }
    }
}
