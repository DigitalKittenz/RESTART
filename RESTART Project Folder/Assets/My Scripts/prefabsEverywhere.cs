using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabsEverywhere : MonoBehaviour
{
    public GameObject cubes;
    public int width = 10;
    public int height = 4;

    // Start is called before the first frame update
    void Start()
    {
        for (int y=0; y<height; ++y)
        {
            for (int x = 0; x<width; ++x)
            {
                Instantiate(cubes, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
