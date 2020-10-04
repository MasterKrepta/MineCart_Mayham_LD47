using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints, stationarySpawnPoints;
    [SerializeField] Transform batsPrefab, turretsPrefab, fallingRockPrefabs;
    int randomPos;
    int maxBats = 10;
    int maxTurrets = 5;
    float nextBatTime = 3f;
    float NextRockTime = 1.5f;


    public float spawnTime = 30f;
    public float rockSpawnTime = 1.5f;
    bool paused = false;


    // Update is called once per frame
    void Update()
    {
       
        

        if (Time.time >= nextBatTime)
        {
            nextBatTime= Time.time + spawnTime;
            Spawn(batsPrefab);
        
        }
        if (Time.time >= NextRockTime)
        {
            NextRockTime = Time.time + rockSpawnTime;
            SpawnStationary(fallingRockPrefabs);
        }
        
    }

    void Spawn(Transform prefab)
    {
        if (paused) return;
        int rand = Random.Range(0, spawnPoints.Length);
        Transform pos = spawnPoints[rand];
        Instantiate(prefab, pos.position, Quaternion.identity);
    }

    void SpawnStationary(Transform prefab)
    {
        if (paused) return;
        int rand = Random.Range(0, stationarySpawnPoints.Length);
        Transform pos = stationarySpawnPoints[rand];
        Instantiate(prefab, pos.position, Quaternion.identity);
    }
    public void TogglePause()
    {
        if (paused)
        {
            paused = false;
        }
        else
        {
            paused = true;
        }
    }
}
