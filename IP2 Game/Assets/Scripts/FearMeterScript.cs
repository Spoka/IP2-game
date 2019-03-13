using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearMeterScript : MonoBehaviour {

    // Use this for initialization
    public LifeLoss other;

    public Slider fearBar;
    public float fear;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

    private const float timeLapse = 2.0f;
=======
    private const float timeLapse = 0.5f;
>>>>>>> parent of 15efe47... fear meter working

=======
    private const float timeLapse = 0.5f;
>>>>>>> parent of 15efe47... fear meter working
=======
    private const float timeLapse = 0.5f;
>>>>>>> parent of 15efe47... fear meter working
=======
    private const float timeLapse = 0.5f;
>>>>>>> parent of 15efe47... fear meter working

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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

        fear -= timeLapse * Time.deltaTime;


        if (isOutside == true)
        {
            fearBar.value = fear;
            fear -= timeLapse * Time.deltaTime;
        }

=======
        fear -= timeLapse * Time.deltaTime;

>>>>>>> parent of 15efe47... fear meter working
=======
        fear -= timeLapse * Time.deltaTime;

>>>>>>> parent of 15efe47... fear meter working
=======
        fear -= timeLapse * Time.deltaTime;

>>>>>>> parent of 15efe47... fear meter working
=======
        fear -= timeLapse * Time.deltaTime;

>>>>>>> parent of 15efe47... fear meter working
    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

            //fear = fear - lT / Time.deltaTime;
            fear -= timeLapse * Time.deltaTime;

            isOutside = true;
            print("fear working");

=======
            //fear = fear - lT / Time.deltaTime;
            fear -= timeLapse * Time.deltaTime;
>>>>>>> parent of 15efe47... fear meter working
=======
            //fear = fear - lT / Time.deltaTime;
            fear -= timeLapse * Time.deltaTime;
>>>>>>> parent of 15efe47... fear meter working
=======
            //fear = fear - lT / Time.deltaTime;
            fear -= timeLapse * Time.deltaTime;
>>>>>>> parent of 15efe47... fear meter working
=======
            //fear = fear - lT / Time.deltaTime;
            fear -= timeLapse * Time.deltaTime;
>>>>>>> parent of 15efe47... fear meter working
        }

        if(fear == 50)
        {
            print("fear to 50");
        }
    }
}
