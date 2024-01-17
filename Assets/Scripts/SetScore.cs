using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetScore : MonoBehaviour
{
    public TMP_Text ScoreCount;
    public GameManager gameManager;
    // Update is called once per frame
    void Update()
    {
        ScoreCount.text = gameManager.score.ToString();
    }
}
