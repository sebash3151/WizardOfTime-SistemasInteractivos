using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnglerLight : MonoBehaviour
{
    [SerializeField]
    GameObject anglersEyes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {/*
        if (GameObject.Find("GameController").GetComponent<DetectLight>().isMoodyLight)
        {
            anglersEyes.SetActive(true);
            //GetComponent<SpriteRenderer>().material.SetColor("_EmissionColor", Color.yellow);
        }
        else
        {
            anglersEyes.SetActive(false);
            //GetComponent<SpriteRenderer>().material.SetColor("_EmissionColor", Color.black);
        }*/
    }
}
