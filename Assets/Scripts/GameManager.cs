using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Null instance of the manager
    public static GameManager instance = null;
    // Bool if it is 1st person perspective, false = 3rd person perspective
    static private bool is1stPP = true;

    private void Awake()
    {
        // SINGLETON PATTERN
        // Check if instance is null
        if (instance == null)
        {
            //Don't destroy the current game manager
            DontDestroyOnLoad(gameObject);

            //Set game manager instance to this
            instance = this;
        }
        // Check if current instance of game manager is equal to this game manager
        else if (instance != this)
        {
            //Destroy the game manager that is not the current game manager
            Destroy(gameObject);
        }
    }

    // Set the perspective, true = 1st PP, false = 3rd PP
    static public void Set1stPP(bool b)
    {
        is1stPP = b; 
    }
    // Get the status of the perspective
    static public bool GetIs1stPP()
    {
        return is1stPP;
    }
}
