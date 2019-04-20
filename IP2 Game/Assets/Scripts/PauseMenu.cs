using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PauseMenu : MonoBehaviour {

    public string Menu;
    public bool IsPaused;
    public GameObject pauseMenuCanvas;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (IsPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1;
            Cursor.visible = false;

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
            Time.timeScale = 0;

        }
	}

    public void Continue()
    {
        IsPaused = false;
        Time.timeScale = 1;
        Cursor.visible = false;
    }
    public void Restart()
    {
        Application.LoadLevel("RotationTestScene");
    }
    public void QuitToMain()
    {
        Application.LoadLevel("MenuScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
