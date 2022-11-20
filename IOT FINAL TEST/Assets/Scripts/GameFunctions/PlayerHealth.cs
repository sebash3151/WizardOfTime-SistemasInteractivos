using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerHealth : MonoBehaviourPunCallbacks, IPunObservable
{
    [SerializeField] int lifes = 3;
    [SerializeField] GameObject heart1;
    [SerializeField] GameObject heart2;
    [SerializeField] GameObject heart3;
    [SerializeField] GameObject x1;
    [SerializeField] GameObject x2;
    [SerializeField] GameObject x3;
    [SerializeField] GameObject podercanvas;
    [SerializeField] AudioSource lostsong;
    [SerializeField] AudioSource auch;
    [SerializeField] EnemySpawner enemies;

    private void Awake()
    {
        heart1 = GameObject.Find("hearts1");
        heart2 = GameObject.Find("hearts (1)");
        heart3 = GameObject.Find("hearts (2)");
        x1 = GameObject.Find("hearts (3)");
        x2 = GameObject.Find("hearts (4)");
        x3 = GameObject.Find("hearts (5)");
    }

    private void Update()
    {
        if (lifes == 2)
        {
            heart3.SetActive(false);
            x3.SetActive(true);
        }
        if(lifes == 1)
        {
            heart2.SetActive(false);
            x2.SetActive(true);
        }
        if (lifes == 0)
        {
            heart1.SetActive(false);
            x1.SetActive(true);
            Perder();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            GetHit();
        }
    }

    private void Perder()
    {
        enemies.active = false;
        lostsong.Stop();
        podercanvas.SetActive(true);

    }

    private void GetHit()
    {
        lifes--;
        auch.Play();
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(lifes);
        }
        else
        {
            lifes = (int)stream.ReceiveNext(); 
        }
    }
}
