using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastorBehavior : MonoBehaviour
{
    public int score;
    public int spawnCount = 10; // Set the number of objects you want to spawn
    public float spawnInterval = 2f; // Set the interval between each spawn
    private float timer = 0f;

    void Start()
    {
        // Instantiate castor at a random position
        transform.position = new Vector3(Random.Range(-5f, 5f), 0.5f, Random.Range(-5f, 5f));
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer -= spawnInterval;
            Mudarposicao();
        }
        if (Input.GetMouseButtonDown(0))
        {
            // Destroy castor and increment score
            Destroy(gameObject);
            score++;
            Mudarposicao();
        }
    }

    void Mudarposicao(){
        // Instantiate castor at a random position
        transform.position = new Vector3(Random.Range(-5f, 5f), 0.5f, Random.Range(-5f, 5f));
    }
}