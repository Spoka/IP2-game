using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour {

    public PlayerScript playerScript;
    public Player2Script player2Script;
    public GameObject placedStuff;
    public bool isPlaced = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == placedStuff)
        {
            if (playerScript.isParent == true || player2Script.is2Parent == true)
            {
                //other.transform.SetParent(gameObject.transform);
                isPlaced = true;
                //playerScript.isParent = false;
                //player2Script.is2Parent = false;
            }
        }
    }
}
