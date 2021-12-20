using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingUI : MonoBehaviour
{
    // The titles of the testing scene
    [SerializeField] private GameObject firstPPHeader = null;
    [SerializeField] private GameObject thirdPPHeader = null;
    private void Start()
    {
        // Set the header based on the game manager saved perspective choice value
        if (GameManager.GetIs1stPP())
        {
            firstPPHeader.SetActive(true);
            thirdPPHeader.SetActive(false);
        }
        else
        {
            firstPPHeader.SetActive(false);
            thirdPPHeader.SetActive(true);
        }
    }
}
