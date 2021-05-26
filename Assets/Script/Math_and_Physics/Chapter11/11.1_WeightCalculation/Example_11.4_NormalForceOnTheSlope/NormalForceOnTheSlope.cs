using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalForceOnTheSlope : MonoBehaviour
{
    public float n;
    public float n1;
    public float lbs;
    public float angle;
    public float normalForce;

    // Start is called before the first frame update
    void Start()
    {
        n = lbs / n1;
        normalForce = n * Mathf.Cos(angle * Mathf.Deg2Rad);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
