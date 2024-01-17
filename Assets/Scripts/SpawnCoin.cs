using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coin;
    public float SpawnInterval; // Time between spawning of new coins
    public float SpawnDelay; // Time delay before first spawn
    private float spawnTimer;
    private float spawnDelayTimer;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = SpawnInterval;
        spawnDelayTimer = SpawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnDelayTimer < 0)
        {
            if (spawnTimer > 0)
            {
                spawnTimer -= Time.deltaTime;
            }
            else
            {
                spawnTimer = SpawnInterval;
                Vector3 newPos = new Vector3(Random.Range(-14f, 14f), 1.25f, Random.Range(-14f, 14f));
                Instantiate(coin, newPos, coin.transform.rotation);
            }
        }
        else
        {
            spawnDelayTimer -= Time.deltaTime;
        }
    }
}
