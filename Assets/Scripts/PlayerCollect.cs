using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerCollect : MonoBehaviour
{
    public GameObject coin;
    public GameManager gameManager;
    private float frameRate;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "Player")
        {
            gameManager.score += 1;
            coin.SetActive(false);
            gameManager.FPSDebugCounter += 1;
            if (gameManager.FPSDebugCounter >= 3)
            {
                gameManager.FPSDebugCounter = 0;
                frameRate = 1.0f / Time.deltaTime;
                Debug.Log("Frame rate: " + frameRate.ToString("#.00"));
            }
        }
        return;
    }
}
