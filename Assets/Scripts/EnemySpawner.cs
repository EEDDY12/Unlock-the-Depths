using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject skeletonPrefab;
    public float spawnInterval = 5f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(skeletonPrefab, transform.position, transform.rotation);
    }
}
