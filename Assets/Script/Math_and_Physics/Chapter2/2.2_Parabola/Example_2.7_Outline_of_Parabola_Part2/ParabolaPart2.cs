using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolaPart2 : MonoBehaviour
{
     public float a;
    public float h;
    public float k;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = -100; i < 100; i++)
        {
            float y = i;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            float x = a * ((y - h) * (y - h)) + k;
            cube.transform.position = new Vector3(x, y, 0);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
