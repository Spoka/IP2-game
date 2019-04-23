using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    Scene currentScene;
    string sceneName;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    private void Update()
    {
        if (sceneName == "MenuScene")
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                SceneManager.LoadScene("RotationTestScene");
            }

            if (Input.GetKeyDown(KeyCode.JoystickButton2))
            {
                SceneManager.LoadScene("OptionsMenu");
            }

            if (Input.GetKeyDown(KeyCode.JoystickButton1))
            {
                Application.Quit();
            }
        }
        if (sceneName == "OptionsMenu")
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton1))
            {
                SceneManager.LoadScene("MenuScene");
            }
        }
        if (sceneName == "Cutscene")
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton7))
            {
                SceneManager.LoadScene("MenuScene");
            }
        }
        if (sceneName == "GameOverScene")
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                SceneManager.LoadScene("RotationTestScene");
            }

            if (Input.GetKeyDown(KeyCode.JoystickButton1))
            {
                SceneManager.LoadScene("MenuScene");
            }
        }
        if (sceneName == "SuccessScreen")
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton1))
            {
                SceneManager.LoadScene("MenuScene");
            }
        }
    }

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
