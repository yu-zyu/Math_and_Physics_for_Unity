using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolaPart1 : MonoBehaviour
{
    public float a;
    public float h;
    public float k;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = -100; i < 100; i++)
        {
            float x = i;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            float y = a * ((x - h) * (x - h)) + k;
            cube.transform.position = new Vector3(x, y, 0);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
