using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationOfMass : MonoBehaviour
{
    public float lbs;
    public float w;
    public float m;
    public float g;
    public float n;

    // Start is called before the first frame update
    void Start()
    {
        w = lbs / n;
        m = w / g ;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
