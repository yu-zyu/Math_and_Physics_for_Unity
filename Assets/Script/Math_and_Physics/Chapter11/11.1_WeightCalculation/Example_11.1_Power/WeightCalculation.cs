using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightCalculation : MonoBehaviour
{
    public float w;
    public float m;
    public float g;
    public float lbs;
    public float n;

    // Start is called before the first frame update
    void Start()
    {
        w = m * g;
        lbs = w * n;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
