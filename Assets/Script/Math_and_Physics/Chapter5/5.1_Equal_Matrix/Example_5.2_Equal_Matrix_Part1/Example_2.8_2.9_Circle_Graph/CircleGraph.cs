﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleGraph : MonoBehaviour
{
    public float h;
    public float k;
    public float r;
    public float sqrtR;

    // Start is called before the first frame update
    void Start()
    {
        h = gameObject.transform.position.x;
        k = gameObject.transform.position.y;
        sqrtR = Mathf.Sqrt(r);
        for (float i = h - sqrtR; i <= h + sqrtR; i += 0.1f)
        {
            float x = i;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            float y1 = Mathf.Sqrt(r - Mathf.Pow(x - h, 2)) + k;
            float y2 = -Mathf.Sqrt(r - Mathf.Pow(x - h, 2)) + k;
            cube.transform.position = new Vector3(x, y1, 0);
            cube2.transform.position = new Vector3(x, y2, 0);
            cube.transform.parent = gameObject.transform;
            cube2.transform.parent = gameObject.transform;
        }
       // float r = ((x - h) * (x - h)) + ((y - k) * (y - k)) + k;
    }

    // Update is called once per frame
    void Update()
    {
        h = gameObject.transform.position.x;
        k = gameObject.transform.position.y;
        
    }
}
