using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt_m : MonoBehaviour
{
    public float[] P1 = new float[2];
    public float[] P2 = new float[2];

    // Use this for initialization
    void Start()
    {
        float m;
        m = Math_and_PhysicsLib.slopeBetweenPoints(P1, P2);
        Debug.LogFormat("float:  "+ m);
    }
}
