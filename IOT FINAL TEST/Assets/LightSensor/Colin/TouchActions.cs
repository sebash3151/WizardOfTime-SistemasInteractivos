using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.InputSystem;



public class TouchActions : MonoBehaviour
{
    [SerializeField]
    GameObject spawner;

    [SerializeField]
    AudioSource speaker;

    [SerializeField]
    AudioClip waterSFX;

    float delay = 0;

    private TouchControls controls;
    bool spawnWater = false;

    private void Awake(){
        controls = new TouchControls();
    }

    private void OnEnable(){
        controls.Enable();
    }

    private void OnDisable(){
        controls.Disable();
    }

    public float speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        controls.MultiTouch.SpawnWater.performed += ctx => SpawnWaterPressed();
        controls.MultiTouch.SpawnWaterStop.performed += ctx => SpawnWaterReleased();
        
        
        var mouse = Mouse.current;
        if (mouse == null){
            return;
        }
    }

    private void SpawnWaterPressed(){
        Debug.Log("Pressed");
        spawnWater = true;
    }

    

    // Update is called once per frame
    void Update()
    {
        delay += Time.deltaTime;
        if(spawnWater && delay > 0.1f){
            Debug.Log("Spawning water");
            spawner.GetComponent<Water2D.Water2D_Spawner>().RunSpawner();
            speaker.PlayOneShot(waterSFX, 0.05f);
            delay = 0;
        }
        else{
            spawner.GetComponent<Water2D.Water2D_Spawner>().JustStopSpawner();
        }
        
        Vector2 mousePos = controls.MultiTouch.MousePosition.ReadValue<Vector2>();
        Vector2 objectPos = Camera.main.WorldToScreenPoint(transform.position);

        mousePos.x = (mousePos.x - objectPos.x);
        mousePos.y = (mousePos.y - objectPos.y);

        Vector2 targetPos = Camera.main.ScreenToWorldPoint(controls.MultiTouch.MousePosition.ReadValue<Vector2>());
        
        
        
        transform.position = 
        Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        //if(controls.MultiTouch.SpawnWater.wasPressedThisFrame){
        //    Debug.console("wow");
        //}
    }
    private void SpawnWaterReleased(){
        Debug.Log("Released");
        spawnWater = false;
    }
}
