using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerManager : MonoBehaviourPun
{
    public GameObject mago1;
    public GameObject mago2;
    [SerializeField] Transform spawnPoint1;
    [SerializeField] Transform spawnPoint2;

    private void Awake()
    {
        SpawnAllPlayers();
    }

    private void SpawnAllPlayers()
    {
        Transform spawnpoint = (PhotonNetwork.IsMasterClient) ? spawnPoint1 : spawnPoint2;
        GameObject magos = (PhotonNetwork.IsMasterClient) ? mago1 : mago2;

        PhotonNetwork.Instantiate(magos.name, spawnpoint.position, spawnpoint.rotation);

    }

}
