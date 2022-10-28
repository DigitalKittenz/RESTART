using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootPrefab : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 5;
    void Update()
    {
        if (Input.GetButtonDown("SHOOT"))
        {
            Rigidbody project = Instantiate(projectile, transform.position, transform.rotation);
            project.velocity = transform.forward * speed;
        }
    }
    // Start is called before the first frame update
    void Start()
    {


        {

        }
    }
}
