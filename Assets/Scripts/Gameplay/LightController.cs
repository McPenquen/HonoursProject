using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] GameObject player = null;
    [SerializeField] private int activeLight1 = 0;
    [SerializeField] private int activeLight2 = 1;
    [SerializeField] private int activeLight3 = 2;
    // All lights positions
    private Vector3[] lightPositions;
    void Start()
    {
        // Disable all lights
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
        // Activate only the one the player is closest to
        activeLight1 = 0;
        activeLight2 = 1;
        activeLight3 = 2;
        gameObject.transform.GetChild(activeLight1).gameObject.SetActive(true);
        gameObject.transform.GetChild(activeLight2).gameObject.SetActive(true);
        gameObject.transform.GetChild(activeLight3).gameObject.SetActive(true);

    }

    void Update()
    {
        
    }
}
