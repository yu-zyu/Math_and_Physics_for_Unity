using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using System.Runtime.InteropServices;

public class LineIntersect : MonoBehaviour
{
    public float[] L1point = new float[2];
    public float L1slope;
    public float[] L2point = new float[2];
    public float L2slope;
    public float a;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        //float[] m;
        IntPtr m;
        m = Math_and_PhysicsLib.lineIntersect(L1point, L1slope, L2point, L2slope);
        float[] arrayFloat = new float[2];
        Marshal.Copy(m, arrayFloat, 0,2);

        Debug.Log("pointX:  "+ arrayFloat[0]);
        Debug.Log("pointY:  "+ arrayFloat[1]);
      //  Debug.LogFormat("float:  {0},{1}", m[0], m[1]);
      //  Debug.Log("pointX:  "+ m[0]);
      //  Debug.Log("pointY:  "+ m[1]);

        GenerateLine("straight1List", L1slope, L1point);
        GenerateLine("straight2List", L2slope, L2point);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 void GenerateLine(string lineName, float slope, float[] point)
    {
        GameObject straight2List = GameObject.CreatePrimitive(PrimitiveType.Cube);
        straight2List.name = lineName;

        for (int i = 0; i < 100; i++)
        {
            float x = i;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            float y = slope * (x - point[0]) + point[1];
            cube.transform.position = new Vector3(x, y, 0);
            cube.transform.parent = straight2List.transform;
        }
    }

}
