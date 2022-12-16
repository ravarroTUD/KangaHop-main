using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] objects;
    public float minSpawnTime,
        maxSpawnTime;
    public bool spawnMovingObjects = false;

    // Spawn both moving and static objects when game starts
    void Start()
    {
        if (spawnMovingObjects)
        {
            SpawnMovingObjects();
        }
        else
        {
            SpawnStaticObjects();
        }
    }

    // Update is called once per frame
    void Update() { }

    // Spawn the cars and the wooden planks
    void SpawnMovingObjects()
    {
        Instantiate(objects[Random.Range(0, objects.Length)], transform);
        Invoke("SpawnMovingObjects", Random.Range(minSpawnTime, maxSpawnTime));
    }

    // Spawn the randomised cactus'
    void SpawnStaticObjects()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(
                objects[Random.Range(0, objects.Length)],
                new Vector3(Random.Range(-5, 5), 0, transform.position.z),
                Quaternion.identity
            );
        }
    }
}
