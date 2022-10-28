using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class gravityPlacement : MonoBehaviour
{
    private Rigidbody rigbody; public Transform centerOfGravity;
    // Start is called before the first frame update
    void Start()   
    {
        rigbody = GetComponent<Rigidbody>();        
        if (centerOfGravity)        
        {            
           rigbody.centerOfMass = centerOfGravity.localPosition;        
        }    
    }
}