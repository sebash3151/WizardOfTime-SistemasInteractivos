using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTime : MonoBehaviour
{
    [SerializeField] DetectLight actualLight;
    [SerializeField] Color dia;
    [SerializeField] Material diamat;
    [SerializeField] Color tarde;
    [SerializeField] Material tarmat;
    [SerializeField] Color noche;
    [SerializeField] Material nochmat;
    [SerializeField] Light directionalLight;


    void Update()
    {
        if (actualLight.day)
        {
            directionalLight.color = dia;
            RenderSettings.skybox = diamat;
        }
        else if(actualLight.dawn)
        {
            directionalLight.color = tarde;
            RenderSettings.skybox = tarmat;
        }
        else if (actualLight.night)
        {
            directionalLight.color = noche;
            RenderSettings.skybox = nochmat;
        }
    }
}
