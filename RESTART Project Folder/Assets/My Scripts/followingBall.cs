using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followingBall : MonoBehaviour
{
    //so you can put a gameobject inside
    public GameObject player;       

    //this is the offset between the camera and the game object
    private Vector3 offset;           

    // start!
    void Start()
    {
        //maths stuff: - get the distance between the gameobject and the camera's position. That's the offset.
        offset = transform.position - player.transform.position;
    }

    // happens after each frame's updates.
    void LateUpdate()
    {
        // camera and gameobjects are the same PLUS the offset.  
        transform.position = player.transform.position + offset;
    }
}