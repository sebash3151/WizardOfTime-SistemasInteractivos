using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerManager : MonoBehaviourPun
{
    public GameObject[] magos;
    [SerializeField] Transform[] spawnPoints;

    private void Start()
    {
        SpawnAllPlayers();
    }

    private void SpawnAllPlayers()
    {
        for (int i = 0; i < magos.Length; i++)
        {
            PhotonNetwork.Instantiate(magos[i].name, spawnPoints[i].position, spawnPoints[i].rotation);
        }
    }

}
