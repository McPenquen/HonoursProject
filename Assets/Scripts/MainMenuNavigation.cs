using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigation : MonoBehaviour
{
    // Play scenario with 3rd person perspective
    public void Play1stPP()
    {
        SceneManager.LoadScene("1Person");
    }

    // Play scenario with 3rd person perspective
    public void Play3rdPP()
    {
        SceneManager.LoadScene("3Person"); 
    }
    // Exit the application
    public void Exit()
    {
        Application.Quit();
    }

}
