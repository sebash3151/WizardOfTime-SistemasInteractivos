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

    public void Spawn1()
    {
        Instantiate(Enemies[0], Spawners[Random.Range(0, Enemies.Length)]);
    }

    public void Spawn2()
    {
        Instantiate(Enemies[1], Spawners[Random.Range(0, Enemies.Length)]);
    }

    public void Spawn3()
    {
        Instantiate(Enemies[2], Spawners[Random.Range(0, Enemies.Length)]);
    }

    public void Spawn4()
    {
        Instantiate(Enemies[3], Spawners[Random.Range(0, Enemies.Length)]);
    }

    public void Spawn5()
    {
        Instantiate(Enemies[4], Spawners[Random.Range(0, Enemies.Length)]);
    }

    public void Spawn6()
    {
        Instantiate(Enemies[5], Spawners[Random.Range(0, Enemies.Length)]);
    }

}
