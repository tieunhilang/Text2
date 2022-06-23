using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEgg : MonoBehaviour
{
    public GameObject[] Spawn;
    public GameObject[] Egg;

    public float minSpawnTime = 0.5f;
    public float maxSpawnTime = 1.5f;
    private float lastSpawnTime = 0f;
    private float SpawnTime = 0f;

    public void Start()
    {
        UpdateSpawnTime();
    }

    public void UpdateSpawnTime()
    {
        lastSpawnTime = Time.time;

        SpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }


    public void CreatEgg()
    {
        int PointEgg = Random.Range(0, Egg.Length);
        int PointSpawn = Random.Range(0, Spawn.Length);
        Instantiate(Egg[PointEgg], Spawn[PointSpawn].transform.position, Quaternion.identity);
        UpdateSpawnTime();
    }

    public void Update()
    {
        if(Time.time >= lastSpawnTime + SpawnTime)
        {
            CreatEgg();
        }
    }


}
