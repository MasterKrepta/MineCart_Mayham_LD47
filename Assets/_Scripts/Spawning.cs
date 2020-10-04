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
    float nextTime = 3f;
    
    
    public float spawnTime = 30f;
    


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTime)
        {
            nextTime= Time.time + spawnTime;
            Spawn(batsPrefab);
        }
    }

    void Spawn(Transform prefab)
    {
        int rand = Random.Range(0, spawnPoints.Length);
        Transform pos = spawnPoints[rand];
        Instantiate(prefab, pos.position, Quaternion.identity);
    }
}
