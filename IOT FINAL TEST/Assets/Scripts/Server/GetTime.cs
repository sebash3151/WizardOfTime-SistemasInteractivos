using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTime : MonoBehaviour
{
    [SerializeField] DetectLight actualLight;
    [SerializeField] Color dia;
    [SerializeField] Material diamat;
    [SerializeField] Color noche;
    [SerializeField] Material nochmat;
    [SerializeField] Light directionalLight;


    void Update()
    {
        if (actualLight.dayTime == 1)
        {
            directionalLight.color = dia;
            RenderSettings.skybox = diamat;
        }
        else if (actualLight.dayTime == 0)
        {
            directionalLight.color = noche;
            RenderSettings.skybox = nochmat;
        }
    }
}
