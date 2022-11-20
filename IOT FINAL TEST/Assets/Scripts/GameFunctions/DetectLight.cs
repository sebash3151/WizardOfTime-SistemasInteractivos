using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DetectLight : MonoBehaviour
{
    public bool night = false;
    public bool day = false;
    public bool dawn = false;

    [SerializeField] AudioSource audio;
  
    public void ChangeDay()
    {
        night = false;
        day = true;
        dawn = false;
        audio.Play();
    }

    public void ChangeNight()
    {
        night = true;
        day = false;
        dawn = false;
        audio.Play();
    }
}
