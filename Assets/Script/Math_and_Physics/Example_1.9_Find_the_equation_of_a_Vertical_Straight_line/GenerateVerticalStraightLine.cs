using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateVerticalStraightLine : MonoBehaviour
{
    public float m;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public float VerticalStraightLine(float slope)
    {
        m = Math_and_PhysicsLib.perpSlope(slope);
        return m;
    }

}
