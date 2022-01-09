using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    void Start()
    {
        // Show the score
        GetComponent<TMPro.TextMeshProUGUI>().text = "Your Score: " + GameManager.GetScore();
    }

}
