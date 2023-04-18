using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInput : MonoBehaviour
{
    
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        //transform.position = new Vector3(0, 1, 1);
        transform.Translate(new Vector3(0, 8, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
