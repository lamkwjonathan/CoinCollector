using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowMenuData : MonoBehaviour
{
    public TMP_Text highscoreCount;
    public TMP_InputField playerName;
    // Start is called before the first frame update
    void Start()
    {
        highscoreCount.text = PlayerPrefs.GetInt("Highscore").ToString();
        playerName.text = PlayerPrefs.GetString("Name");
    }
}
