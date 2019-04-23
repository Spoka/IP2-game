using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour {

    public PlayerScript playerScript;
    public Player2Script player2Script;
    public FearMeterScript lightAnimation;
    public GameObject placedStuff;
    public bool isPlaced = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == placedStuff)
        {   
            isPlaced = true;
            lightAnimation.StartLightCoroutine();
        }
    }
}
