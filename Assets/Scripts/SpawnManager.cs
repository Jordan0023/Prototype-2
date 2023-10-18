using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;

    private float xSpawnRange = 20;
    private float zSpawnPos = 20;

    private float startDelay = 1;
    private float spawnInterval = 1f;

    public int[] degree;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

        DestroyOutOfBounds game = new DestroyOutOfBounds();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
       
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnpos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, Random.Range(-zSpawnPos, zSpawnPos));
            int randDegree = Random.Range(0, 3);
       
            Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0, degree[randDegree], 0));
        
        
    }
}
