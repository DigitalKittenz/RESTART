using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class moving : MonoBehaviour
{

    public float xForce = 11.0f;
    public float zForce = 11.0f;
    public float yForce = 450.0f;

    //use this for initialization  

    void Start()
    {

    }
    //Update is called once per frame  
    void Update()
    {
        //x-axis / south movement

        float x = 0.0f;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            x = x - xForce;
        }
        //north movement

        if (Input.GetKey(KeyCode.UpArrow))
        {
            x = x + xForce;
        }

        //z axis / right movement

        float z = 0.0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            z = z - zForce;
        }
        //moving left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            z = z + zForce;
        }
        //z-axis jumping.

        float y = 0.0f;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            y = yForce;
        }

        GetComponent<Rigidbody>().AddForce(x, y, z);
    }
}