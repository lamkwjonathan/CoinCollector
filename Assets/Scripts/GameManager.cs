using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject transitionPanel;
    public float transitionTime; // Transition timing for gameover fade in
    public int score; // Counter to keep track of current score
    public int FPSDebugCounter; // Counter to keep track of FPS debug prints
    public void EndGame()
    {
        player.GetComponent<TouchMovement>().enabled = false;
        PlayerPrefs.SetInt("Score", score);
        if (score > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
        Invoke("Transit", transitionTime);
    }

    public void Transit()
    {
        transitionPanel.SetActive(true);
    }

    void Update()
    {
        if (player.transform.position.y < -1)
        {
            EndGame();
        }
    }
}
