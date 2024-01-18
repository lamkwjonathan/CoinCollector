using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowGameoverScore : MonoBehaviour
{
    public TMP_Text scoreCount;

    // Start is called before the first frame update
    void Start()
    {
        scoreCount.text = PlayerPrefs.GetInt("Score").ToString();
    }
}
