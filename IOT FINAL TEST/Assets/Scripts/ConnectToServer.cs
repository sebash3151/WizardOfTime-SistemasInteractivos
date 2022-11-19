using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviour
{
    [SerializeField] private string URL;
    public int ServerResponse;
    [SerializeField] int enviar = 5;

    public void Connectarse()
    {
        ActualTime ahorita = new ActualTime();
        ahorita.Luz = enviar;
        string json = JsonUtility.ToJson(ahorita);
        StartCoroutine(Connectacion(json));
    }

    public void ConnectarseConSensor(int lectura)
    {
        ActualTime ahorita = new ActualTime();
        ahorita.Luz = lectura;
        string json = JsonUtility.ToJson(ahorita);
        StartCoroutine(Connectacion(json));
    }

    IEnumerator Connectacion(string postData)
    {
        Debug.Log("Registro: " + postData);

        string url = URL + "/send";
        UnityWebRequest www = UnityWebRequest.Put(url, postData);
        www.method = "POST";
        www.SetRequestHeader("content-type", "application/json");


        yield return www.SendWebRequest();

        if (www.isNetworkError)
        {
            Debug.Log("NETWORK ERROR " + www.error);
        }
        else if (www.responseCode == 200)
        {
            Debug.Log("Registrado ");
            ActualTime resData = JsonUtility.FromJson<ActualTime>(www.downloadHandler.text);
            ServerResponse = resData.Luz;
            Debug.Log(resData.Luz);
        }
        else
        {
            Debug.Log(www.error);
        }
    }

    public class ActualTime
    {
        public int Luz;
    }
}
