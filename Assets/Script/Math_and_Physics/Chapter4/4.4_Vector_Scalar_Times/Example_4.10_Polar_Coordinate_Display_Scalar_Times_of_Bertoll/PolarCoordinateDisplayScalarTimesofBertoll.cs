using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolarCoordinateDisplayScalarTimesofBertoll : MonoBehaviour
{
    public float vector;
    public float scalar;
    public float scalarTime;

    // Start is called before the first frame update
    void Start()
    {
        scalarTime = scalar * vector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
