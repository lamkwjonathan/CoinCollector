using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorController : MonoBehaviour
{
    public GameObject player;
    public Material PlayerBlue;
    public Material PlayerPurple;
    public Material PlayerGreen;
    public Material PlayerRed;
    public Material[] materials;
    private int currentMat;

    void Start()
    {
        // Initialize 4 colors as an array for easy access
        materials = new Material[4];
        materials[0] = PlayerBlue;
        materials[1] = PlayerPurple;
        materials[2] = PlayerGreen;
        materials[3] = PlayerRed;
        currentMat = 0; // Variable to keep track of current material 
    }

    public void OnButtonPressed()
    {
        // Change colors on button press, preventing the scenario where the random material chosen is the current one   
        int matNumber = Mathf.FloorToInt(Random.Range(0f, 4f));
        while (matNumber == currentMat)
        {
            matNumber = Mathf.FloorToInt(Random.Range(0f, 4f));
        }
        player.GetComponent<Renderer>().material = materials[matNumber];
        currentMat = matNumber;
    }



    

}
