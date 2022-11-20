using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DetectLight : MonoBehaviour
{
    [SerializeField] Text texto;
    private int lightLevel;
    [SerializeField] Text foco;

    [SerializeField] ConnectToServer server;

    public bool night = false;
    public bool day = false;
    public bool dawn = false;

    [SerializeField] bool Consensor = true;
    [SerializeField] bool SinServer = true;

    [SerializeField] AudioSource audio;
    [SerializeField] Animator anim;

    private float delay = 0.5f;
    private float timer = 0f;

    void FixedUpdate()
    {
        /*if (Consensor)
        {
            InputSystem.EnableDevice(LightSensor.current);
            timer += Time.deltaTime;

            if (LightSensor.current.enabled)
            {
                lightLevel = (int)LightSensor.current.lightLevel.ReadValue();

                if (timer >= delay)
                {
                    server.ConnectarseConSensor(lightLevel);
                    timer = 0f;
                }
                       
            }
        }       

        texto.text = lightLevel.ToString();

        if (SinServer)
        {
            if (lightLevel < 25)
            {
                anim.SetTrigger("Change");
                night = true;
                day = false;
                dawn = false;
                foco.text = "Noche";
                audio.Play();
            }
            else if (lightLevel > 25 && lightLevel < 70)
            {
                anim.SetTrigger("Change");
                night = false;
                day = false;
                dawn = true;
                foco.text = "Atardecer";
                audio.Play();
            }
            else if (lightLevel > 70)
            {
                anim.SetTrigger("Change");
                night = false;
                day = true;
                dawn = false;
                foco.text = "Dia";
                audio.Play();
            }
        }
        else
        {
            if (server.ServerResponse == 0)
            {
                anim.SetTrigger("Change");
                night = true;
                day = false;
                dawn = false;
                foco.text = "Noche";
                audio.Play();
            }
            else if (server.ServerResponse == 1)
            {
                anim.SetTrigger("Change");
                night = false;
                day = false;
                dawn = true;
                foco.text = "Atardecer";
                audio.Play();
            }
            else if (server.ServerResponse == 2)
            {
                anim.SetTrigger("Change");
                night = false;
                day = true;
                dawn = false;
                foco.text = "Dia";
                audio.Play();
            }
        }      */
    }

    public void ChangeDay()
    {
        anim.SetTrigger("Change");
        night = false;
        day = true;
        dawn = false;
        foco.text = "Dia";
        audio.Play();
    }

    public void ChangeNight()
    {
        anim.SetTrigger("Change");
        night = true;
        day = false;
        dawn = false;
        foco.text = "Noche";
        audio.Play();
    }
}
