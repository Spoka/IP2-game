using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoolsCheck : MonoBehaviour {

    public PuzzleScript puzzleBed;
    public PuzzleScript puzzleDesk;
    public PuzzleScript puzzleChair;
    public PuzzleScript puzzleSofa;
    public PuzzleScript puzzleLibrary;
    public PuzzleScript puzzleWardrobe;

    public Animator DoorOpener;
    public AudioClip doorScreech;
    public GameObject doorLight;

	// Update is called once per frame
	void Update ()
    {
        if (puzzleBed.isPlaced == true && puzzleChair.isPlaced == true && puzzleDesk.isPlaced == true && puzzleLibrary.isPlaced == true && puzzleSofa.isPlaced == true && puzzleWardrobe.isPlaced == true)
        {
            DoorOpener.SetTrigger("LevelCompleted");
            AudioSource.PlayClipAtPoint(doorScreech, transform.position);
            doorLight.SetActive(true);
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (puzzleBed.isPlaced == true && puzzleChair.isPlaced == true && puzzleDesk.isPlaced == true && puzzleLibrary.isPlaced == true && puzzleSofa.isPlaced == true && puzzleWardrobe.isPlaced == true)
        {
            if (other.tag == "Player" || other.tag == "Player2")
            {
                StartCoroutine("DelayedVictoryScreen");
            }
        }
    }

    IEnumerator DelayedVictoryScreen()
    {
        yield return new WaitForSeconds(.5f);
        Application.LoadLevel("SuccessScreen");
    }
}
