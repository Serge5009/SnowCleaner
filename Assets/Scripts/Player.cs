using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed = 5.0f;
    public float maxTurnSpeed = 50.0f;
    public float acceleration = 5.0f;

    float speed = 0.0f;
    float turnSpeed = 0.0f;

    void Start()
    {
        speed = 0.0f;
        turnSpeed = maxTurnSpeed;
    }

    void Update()
    {
        if (Input.GetKey("a"))  //  Right turn input
        {
            transform.Rotate(new Vector3(0, -1 * turnSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey("d"))  //  Left turn input
        {
            transform.Rotate(new Vector3(0, 1 * turnSpeed * Time.deltaTime, 0));
        }

        if (Input.GetKey("a") && Input.GetKey("d")) //  Deceleration input
        {
            speed -= acceleration / 2 * Time.deltaTime;
        }
        else                                        //  if not stopping - accelerate
        {
            speed += acceleration * Time.deltaTime;
        }

        if (speed > maxSpeed)   //  Speed limits
            speed = maxSpeed;
        if (speed < maxSpeed / -2)  //  Backwards speed limit is half of the normal one
            speed = maxSpeed / -2;

        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
