using System;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

[Serializable]
public class PlayerIDS
{
    [HideInInspector] public int playerNumber;
    [HideInInspector] Camera camara;
    PhotonView myPhotonView;
    [SerializeField] public Transform spawnPoint;
    [HideInInspector] public GameObject instance;

    void Start()
    {
        camara = instance.GetComponent<Camera>();
        myPhotonView = instance.GetComponent<PhotonView>();

        if (!myPhotonView.IsMine)
        {
            camara.enabled = false;
        }
    }
}
