using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform targetObject;
    private Vector3 initialOffset;
    private Vector3 cameraPosition;
    public Vector3 positionChange;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos.x = -15;
        pos.x = -15;
   
        transform.position = pos;
        initialOffset = transform.position - targetObject.position;   
    }


    void FixedUpdate()
    {
        cameraPosition = targetObject.position + initialOffset;
        transform.position = cameraPosition;
        transform.position += positionChange;
    }
}
