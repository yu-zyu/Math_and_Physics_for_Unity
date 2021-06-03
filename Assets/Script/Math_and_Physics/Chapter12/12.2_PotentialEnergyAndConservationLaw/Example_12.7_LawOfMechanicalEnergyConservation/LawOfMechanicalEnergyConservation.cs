using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LawOfMechanicalEnergyConservation : MonoBehaviour
{
    public float lbs;
    public float n1;
    public float n;
    public float m;
    public float g;
    public float yi;
    public float yf;
    public float vi;
    public float vf;

    // Start is called before the first frame update
    void Start()
    {
        n = lbs / n1;
        m = n / g;

        vf = Mathf.Sqrt(((0.5f * m + Mathf.Pow(vi, 2)) + (m * g * yi)) / ((0.5f * m) + (m * g * yf)));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
