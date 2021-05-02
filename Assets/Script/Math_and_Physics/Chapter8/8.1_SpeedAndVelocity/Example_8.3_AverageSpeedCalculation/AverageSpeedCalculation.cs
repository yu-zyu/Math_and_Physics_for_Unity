using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageSpeedCalculation : MonoBehaviour
{
    public float v;
    public float xf;
    public float xi;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        v = (xf - xi) / t;
        v = v * 60 * 60;
    }
}
