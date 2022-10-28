using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class moving : MonoBehaviour
    //REMEMBER: name must match the name of this file
{

    public float xForce = 11.0f;
    public float zForce = 11.0f;
    public float yForce = 450.0f;

    void Start()
    {
        //runs once at start of game
    }
    //Update is called once per frame  
    void Update()
        //update runs for every frame
    {
        //x-axis / south movement

        float x = 0.0f;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //THIS IS THE EXACT SAME AS X = X - XFORCE!
            x -= xForce;
        }
        //north movement

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //or  x = x + xForce;
            x += xForce;
        }

        //z axis / right movement

        float z = 0.0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //or z = z - zForce;
            z -= zForce;
        }
        //moving left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // or z = z +
            z += zForce;
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