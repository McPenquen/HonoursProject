using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigation : MonoBehaviour
{
    [SerializeField] private bool isFirstPersonPerspective = true;
    public void PlayGame()
    {
        // Load the scene based on if it is the 1st or 3rd player perspective
        if (isFirstPersonPerspective)
        {
            SceneManager.LoadScene("1Person");
        }
        else
        {
            SceneManager.LoadScene("3Person");
        }
    }

    // Set the isFirstPerson boolean
    public void SetIsFirstPerson(bool b)
    {
        isFirstPersonPerspective = b;
    }
}
