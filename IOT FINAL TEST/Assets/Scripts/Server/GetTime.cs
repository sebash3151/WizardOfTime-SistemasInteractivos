using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GetTime : MonoBehaviourPun, IPunObservable
{
    [SerializeField] DetectLight actualLight;
    [SerializeField] Color dia;
    [SerializeField] Material diamat;
    [SerializeField] Color noche;
    [SerializeField] Material nochmat;
    [SerializeField] Light directionalLight;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(actualLight.dayTime);
        }
        else
        {
            actualLight.dayTime = (int)stream.ReceiveNext();
        }
    }

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
