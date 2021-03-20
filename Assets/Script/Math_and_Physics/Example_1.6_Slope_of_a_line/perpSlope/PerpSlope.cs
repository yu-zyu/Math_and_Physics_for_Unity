using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerpSlope : MonoBehaviour
{
    public float slope;
    // Start is called before the first frame update
    void Start()
    {
        float m;
        m = Math_and_PhysicsLib.perpSlope(slope);
        Debug.LogFormat("与えられ直線に垂直な直線の傾き:  "+ m);
    }

}
