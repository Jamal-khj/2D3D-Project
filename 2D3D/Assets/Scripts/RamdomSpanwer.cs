using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdomSpanwer : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    public float SpawnTimer = 2.0f;
    public float Timer;

    // Update is called once per frame
    void Update()
    {
        SpawnTimer -= Time.deltaTime;
        Timer = 2.0f;

        //Spawning enemies
        if (SpawnTimer < 0.0f)
        {
            SpawnTimer = Timer;

            int EnemySpawn = Random.Range(0, enemyPrefabs.Length);
            int SpawnLocation = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyPrefabs[EnemySpawn], spawnPoints[SpawnLocation].position, transform.rotation);
        }
    }
}