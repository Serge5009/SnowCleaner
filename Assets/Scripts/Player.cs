using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * speed;
    }
}
