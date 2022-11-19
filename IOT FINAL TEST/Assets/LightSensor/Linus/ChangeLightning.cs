using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightning : MonoBehaviour
{
    float duration = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        /*if (GameObject.Find("GameController").GetComponent<DetectLight>().isMoodyLight)
        {
            SetMoodyLight();
        }
        else
        {
            SetNormalLight();
        }*/
    }

    private void SetMoodyLight()
    {
        //Debug.Log("moody");
        float t = Mathf.PingPong(Time.time, duration) / duration;
        GetComponent<Light>().color = Color.Lerp(Color.white, Color.gray, t);
    }
        private void SetNormalLight()
    {
        //Debug.Log("normal");
        float t = Mathf.PingPong(Time.time, duration) / duration;
        GetComponent<Light>().color = Color.Lerp(Color.gray, Color.white, t);
    }
}
