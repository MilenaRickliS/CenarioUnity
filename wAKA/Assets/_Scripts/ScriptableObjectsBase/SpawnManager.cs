using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectToSpawn; // Drag and drop the object you want to spawn here
    public int spawnCount = 10; // Set the number of objects you want to spawn
    public float spawnInterval = 2f; // Set the interval between each spawn
    private float timer = 0f;
    public float disappearTime = 5f; // Time until the object disappears

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer -= spawnInterval;
            SpawnObject();
            Destroy(gameObject);
        }
        
    }

    void SpawnObject()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}