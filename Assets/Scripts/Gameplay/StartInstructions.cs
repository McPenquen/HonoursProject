using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInstructions : MonoBehaviour
{
    [SerializeField] private Timer timer = null;
    [SerializeField] private Player player = null;
    void Start()
    {
        // For now disable the timer as long as the instructions are on
        timer.gameObject.SetActive(false);
        player.SetInputDetection(false);
    }

    void Update()
    {
        // If the player presses Enter the instructions disappear and the timer starts
        if (Input.GetKeyDown(KeyCode.Return))
        {
            timer.gameObject.SetActive(true);
            player.SetInputDetection(true);
            gameObject.SetActive(false);
        }
        
    }
}
