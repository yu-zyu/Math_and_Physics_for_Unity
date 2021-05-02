using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageSpeedBetweenFrames : MonoBehaviour
{
    public float v;
    public float xf;
    public float xi;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        v = (xf - xi) / t;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
