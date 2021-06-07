using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationOfMomentumInOneDimension : MonoBehaviour
{
    public float lbs;
    public float n1;
    public float mi;
    public float v;
    public float w;
    public float m;
    public float g;
    public float p;

    // Start is called before the first frame update
    void Start()
    {
        w = -lbs / n1;
        m = w / g;
        v = mi * 1609 / 3600;
        p = m * v;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
