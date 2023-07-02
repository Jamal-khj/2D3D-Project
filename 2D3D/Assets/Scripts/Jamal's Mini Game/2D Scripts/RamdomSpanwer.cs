using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdomSpanwer : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    public float SpawnTimer;
    public float FixedSpawnTimer;

    private void Start()
    {
       SpawnTimer = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer -= Time.deltaTime;

        //Spawning enemies
        if (SpawnTimer < 0.0f)
        {
            SpawnTimer = FixedSpawnTimer;

            int EnemySpawn = Random.Range(0, enemyPrefabs.Length);
            int SpawnLocation = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyPrefabs[EnemySpawn], spawnPoints[SpawnLocation].position, transform.rotation);
        }
    }
}