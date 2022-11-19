using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int lifes;
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
        Debug.Log("colisiion");
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("auch");
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
}
