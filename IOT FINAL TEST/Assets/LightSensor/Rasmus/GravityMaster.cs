using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class GravityMaster : MonoBehaviour
{
    void Start()
    {
        //Input.gyro.enabled = true;
        InputSystem.EnableDevice(UnityEngine.InputSystem.GravitySensor.current);
    }

    void Update()
    {  
        //Gyroscope gyro = Input.gyro;
        Physics2D.gravity = GravitySensor.current.gravity.ReadValue() * 9.82f;
    }
}
