using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Photon.Pun;

public class DetectLight : MonoBehaviourPunCallbacks, IPunObservable
{
    public bool night = false;
    public bool day = false;
    public int dayTime = 0;

    //[SerializeField] AudioSource audio;

    [PunRPC]
    public void ChangeDay()
    {
        dayTime = 1;
        //audio.Play();
    }
    [PunRPC]
    public void ChangeNight()
    {
        dayTime = 0;
        //audio.Play();
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(dayTime);
        }
        else
        {
            dayTime = (int)stream.ReceiveNext();
        }
    }
}
