using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

    public void LoadMainLevel()
    {
        Application.LoadLevel("RotationTestScene");
    }
    public void LoadOptions()
    {
        Application.LoadLevel("OptionsMenu");
    }
    public void LoadMainMenu()
    {
        Application.LoadLevel("MenuScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
