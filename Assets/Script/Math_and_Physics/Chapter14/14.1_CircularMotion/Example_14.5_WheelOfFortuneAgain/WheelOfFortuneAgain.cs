using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelOfFortuneAgain : MonoBehaviour
{
    public float omegaI;
    public float omegaF;
    public float t;
    public float a;
    public float at;
    public float r;

    // Start is called before the first frame update
    void Start()
    {
        a = (omegaF - omegaI) / t;
        at = a * r;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
