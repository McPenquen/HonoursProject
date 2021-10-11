using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Null instance of the manager
    public static GameManager instance = null;
    // Main menu navigation
    [SerializeField] private MainMenuNavigation mainMenuNavigation = null;
    [Header("Perspective choice")]
    [SerializeField] private bool isFirstPersonPerspective = true;
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
    void Start()
    {
        // Save main menu navigation
        mainMenuNavigation = GameObject.Find("MenuCanvas").GetComponent<MainMenuNavigation>();
        // Set the perspective based on the game manager's choice
        mainMenuNavigation.SetIsFirstPerson(isFirstPersonPerspective);
    }
}
