using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MidpointBetweenTwoPoints3D : MonoBehaviour
{
    public Transform P1_transform;
    public Transform P2_transform;
    public Transform P3_transform;
    public float[] P1 = new float[3];
    public float[] P2 = new float[3];

    public float m;
    public float distance;
    public float[] midPoint = new float[3];
    public LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        P1[0] = P1_transform.position.x;
        P1[1] = P1_transform.position.y;
        P1[2] = P1_transform.position.z;
        P2[0] = P2_transform.position.x;
        P2[1] = P2_transform.position.y;
        P2[2] = P2_transform.position.z;
        m = Math_and_PhysicsLib.slopeBetweenPoints(P1, P2);
        distance = Math_and_PhysicsLib.distance2D(P1, P2);
        IntPtr mid  = Math_and_PhysicsLib.find3DMidPoint(P1, P2);
        Marshal.Copy(mid, midPoint, 0,3);
        lineRenderer.SetPosition(0, P1_transform.position);
        lineRenderer.SetPosition(1, P2_transform.position);
        P3_transform.position = new Vector3(midPoint[0], midPoint[1], midPoint[2]);
       // Debug.LogFormat("float:  "+ m);
        
    }
}


