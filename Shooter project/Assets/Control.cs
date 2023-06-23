using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed;
    public float nitrospeed;
    
    
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += (Vector3.forward * speed)*Time.deltaTime;
        

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += (Vector3.back * speed)*Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (Vector3.left * speed)*Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.right * speed)*Time.deltaTime;

        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed=speed+nitrospeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed -nitrospeed;
        }

        

    }
}
