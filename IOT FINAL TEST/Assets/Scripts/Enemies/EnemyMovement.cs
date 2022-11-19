using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] bool walking = true;
    private Transform trans;

    void Start()
    {
        trans = GetComponent<Transform>();
    }

    void Update()
    {
        if (walking)
        {
            trans.position -= new Vector3(0, 0, Time.deltaTime * movementSpeed);
        }
    }
}
