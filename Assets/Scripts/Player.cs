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
        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, -1, 0));
        }
        else if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, 1, 0));
        }
    }
}
