using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigation : MonoBehaviour
{
    // Play scenario with 1st person perspective
    public void Play1stPP()
    {
        // Set it to 1st PP
        GameManager.Set1stPP(true);
        SceneManager.LoadScene("TestingEnvironment");
    }

    // Play scenario with 3rd person perspective
    public void Play3rdPP()
    {
        // Set it to not 1st PP (3rd PP)
        GameManager.Set1stPP(false);
        SceneManager.LoadScene("TestingEnvironment"); 
    }
    // Exit the application
    public void Exit()
    {
        Application.Quit();
    }
    // Return to the main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
