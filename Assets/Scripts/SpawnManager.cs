using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManage : MonoBehaviour
{
    public GameObject [] animalPrefabs;
    private float SpawnRangeX = 15.0f;
    private float SpawnPosZ = 20.0f;
    private float StartDelay = 2.0f;
    private float spawnInt = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", StartDelay,spawnInt );
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
