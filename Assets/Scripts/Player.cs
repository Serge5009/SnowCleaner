using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed = 5.0f;
    public float maxTurnSpeed = 50.0f;

    float speed = 0.0f;
    float turnSpeed = 0.0f;

    void Start()
    {
        speed = maxSpeed;
        turnSpeed = maxTurnSpeed;
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, -1 * turnSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, 1 * turnSpeed * Time.deltaTime, 0));
        }

        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
