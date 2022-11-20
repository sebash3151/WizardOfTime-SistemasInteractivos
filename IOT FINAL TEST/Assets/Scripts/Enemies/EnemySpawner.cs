using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class EnemySpawner : MonoBehaviourPun
{
    [SerializeField] Transform[] Spawners;
    [SerializeField] GameObject[] Enemies;
    [SerializeField] float spawnTime = 5f;
    private float timer = 0f;
    public bool active = true;

    public void Spawn(int onject)
    {
        PhotonNetwork.Instantiate(Enemies[onject].name, Spawners[Random.Range(0, Enemies.Length - 1)].position, Quaternion.identity);
    }

}
