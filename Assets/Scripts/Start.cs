using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Start : MonoBehaviour
{
    public TMP_InputField playerName;
    public void StartGame()
    {
        PlayerPrefs.SetString("Name", playerName.text);
        SceneManager.LoadScene("Level_1");
    }
}
