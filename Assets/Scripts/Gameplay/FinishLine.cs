using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private GameObject victorySign = null;
    [SerializeField] private bool isEnding = false;
    private float countDown = 0.0f;

    void Start()
    {
        isEnding = false; // make sure it is false
        victorySign.SetActive(false); // hide victory sign
    }
    void Update()
    {
        // If it's ending wait 3s and end
        if (isEnding)
        {
            countDown += Time.deltaTime;
            // when it is 3s quit the game
            if (countDown >= 3.0f)
            {
                SceneManager.LoadScene("ScoreScene");
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        // If the player collides the game ends
        if (col.gameObject.layer == 10)
        {
            isEnding = true;
            // Save the score
            GameManager.SaveScore(Timer.GetScore());
            victorySign.SetActive(true);
        }
    }
}
