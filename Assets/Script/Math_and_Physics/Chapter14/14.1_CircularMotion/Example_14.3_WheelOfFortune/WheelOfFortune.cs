using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelOfFortune : MonoBehaviour
{
    public float angle;
    public float omegaI;
    public float t;
    public float a;

    // Start is called before the first frame update
    void Start()
    {
        angle = (omegaI * t) + (a * Mathf.Pow(t, 2)) / 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
