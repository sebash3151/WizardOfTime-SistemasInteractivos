using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemies : MonoBehaviour
{
    [SerializeField] bool nocturno = false;
    [SerializeField] float health = 100;
    [SerializeField] DetectLight actualLight;
    [SerializeField] int damage;
    [SerializeField] Scrollbar lifeBar;

    void Start()
    {
        actualLight = GameObject.Find("GameController").GetComponent<DetectLight>();
    }


    void Update()
    {
        if(nocturno && actualLight.dayTime==1)
        {
            health -= Time.deltaTime * damage;
        }

        if(!nocturno && actualLight.dayTime==0)
        {
            health -= Time.deltaTime * damage;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        lifeBar.size = health / 100;
    }
}
