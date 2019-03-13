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
<<<<<<< HEAD
    private const float timeLapse = 0.5f;
=======
    private const float timeLapse = 2.0f;
>>>>>>> 15efe47b59396775656a3772690d058f42c8ba8a

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
<<<<<<< HEAD

        fear -= timeLapse * Time.deltaTime;

=======
        if (isOutside == true)
        {
            fearBar.value = fear;
            fear -= timeLapse * Time.deltaTime;
        }
>>>>>>> 15efe47b59396775656a3772690d058f42c8ba8a
    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
<<<<<<< HEAD
            //fear = fear - lT / Time.deltaTime;
            fear -= timeLapse * Time.deltaTime;
=======
            isOutside = true;
            print("fear working");
>>>>>>> 15efe47b59396775656a3772690d058f42c8ba8a
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
