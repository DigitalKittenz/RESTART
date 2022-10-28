using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabInstatiate : MonoBehaviour
{
    //reference the prefab
    public GameObject myPrefab;
    //so it'll instantiate when the game starts

    // Start is called before the first frame update
    void Start()
    {
        //instantiation at this position.
        Instantiate(myPrefab, new Vector3(0, 2, 0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
