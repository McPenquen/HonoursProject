using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscButton : MonoBehaviour
{
    [SerializeField] private GameObject popWindow = null;

    private void Start()
    {
        // the pop windwo is off at the start
        popWindow.SetActive(false);
    }
    void Update()
    {
        // If the ESC is pressed trigger ESC function
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscFunctionPopWindow();
        }
    }

    // EscFunction - pops up a window/ hide it again
    public void EscFunctionPopWindow()
    {
        // Hide or show the pop window
        if (!popWindow.active)
        {
           popWindow.SetActive(true); 
        }
        else
        {
            popWindow.SetActive(false); 
        }
    }

    // Exit to the main menu
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
