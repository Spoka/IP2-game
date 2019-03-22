using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoolsCheck : MonoBehaviour {

    public PuzzleScript puzzleBed;
    public PuzzleScript puzzleDesk;
    public PuzzleScript puzzleChair;
    public PuzzleScript puzzleSofa;
    public PuzzleScript puzzleLibrary;
    public PuzzleScript puzzleLamp;
    public PuzzleScript puzzleWardrobe;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (puzzleBed.isPlaced == true && puzzleChair.isPlaced == true && puzzleDesk.isPlaced == true && puzzleLamp.isPlaced == true && puzzleLibrary.isPlaced == true && puzzleSofa.isPlaced == true && puzzleWardrobe.isPlaced == true)
        {
            StartCoroutine("DelayedVictoryScreen");
        }
	}

    IEnumerator DelayedVictoryScreen()
    {
        new WaitForSeconds(.7f);
        Application.LoadLevel("SuccessScreen");
        yield return null;
    }
}
