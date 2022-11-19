using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] bool cargando = false;
    [SerializeField] float tiempo = 3f;
    private float timer = 0f;
    [SerializeField] int scene;
    private int erizo = 0;

    private void Update()
    {
        if (cargando)
        {
            timer += Time.deltaTime;
            if (timer >= tiempo)
            {
                SceneManager.LoadScene(scene);
            }
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void Salir()
    {
        Application.Quit();
        //Debug.Log("salio");
    }

    public void Toque()
    {
        erizo++;
        if (erizo >= 5)
        {
            SceneManager.LoadScene(3);
        }
    }
}
