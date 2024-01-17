using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitScene : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    public void LoadGameOver()
    {
        SceneManager.LoadScene("Gameover");
    }
}
