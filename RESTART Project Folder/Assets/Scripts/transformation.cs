using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformation : MonoBehaviour
{
    //note: vector3 means it works with 3 different values. 
    public Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is so the ball grows.
        transform.localScale = transform.localScale + scaleChange;
        //could also write this as +=
    }
}
