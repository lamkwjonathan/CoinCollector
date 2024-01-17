using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public GameObject gameManager;
    public float timeRemaining;
    public TMP_Text TimeCount;
    private int timeRemainingInt;
    private bool isGameRunning = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timeRemainingInt = Mathf.CeilToInt(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timeRemainingInt = 0;
                isGameRunning = false;
            }
            TimeCount.text = timeRemainingInt.ToString();
        }
        else
        {
            gameManager.GetComponent<GameManager>().EndGame();
        }
    }
}
