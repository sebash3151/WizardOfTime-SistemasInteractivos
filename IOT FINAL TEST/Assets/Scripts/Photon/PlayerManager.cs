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
    [SerializeField] CanvasGroup canvas1;
    [SerializeField] CanvasGroup canvas2;

    private void Awake()
    {
        SpawnAllPlayers();
    }

    private void SpawnAllPlayers()
    {
        Transform spawnpoint = (PhotonNetwork.IsMasterClient) ? spawnPoint1 : spawnPoint2;
        GameObject magos = (PhotonNetwork.IsMasterClient) ? mago1 : mago2;

        if (PhotonNetwork.IsMasterClient)
        {
            canvas1.alpha = 1;
            canvas2.alpha = 0;
            canvas1.interactable = true;
            canvas2.interactable = false;
        }
        else
        {
            canvas1.alpha = 0;
            canvas2.alpha = 1;
            canvas1.interactable = false;
            canvas2.interactable = true;
        }

        object[] initData = new object[1];
        initData[0] = "Data instace";

        PhotonNetwork.Instantiate(magos.name, spawnpoint.position, spawnpoint.rotation, 0, initData);
    }

}
