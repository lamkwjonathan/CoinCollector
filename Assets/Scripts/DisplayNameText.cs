using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayNameText : MonoBehaviour
{
    public TMP_Text nameText;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = PlayerPrefs.GetString("Name");
    }
}
