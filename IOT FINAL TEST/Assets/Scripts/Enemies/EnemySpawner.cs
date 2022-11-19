using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Transform[] Spawners;
    [SerializeField] GameObject[] Enemies;
    [SerializeField] float spawnTime = 5f;
    private float timer = 0f;
    public bool active = true;

    void Update()
    {
        if (active)
        {
            timer += Time.deltaTime;

            if (timer >= spawnTime)
            {
                SpawnEnemy();
                timer = 0f;
            }
        }
        
    }

    private void SpawnEnemy()
    {
        Instantiate(Enemies[Random.Range(0, Spawners.Length)], Spawners[Random.Range(0, Enemies.Length)]);
       
    }


}
