using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KineticEnergyCalculation : MonoBehaviour
{
    public float mi;
    public float m;
    public float g;
    public float kg;
    public float ke;
    public float v;

    // Start is called before the first frame update
    void Start()
    {
        v = (mi * 1609) / (60 * 60);
        kg = m / 1000;

        //KE = 1/2mv^2
        ke = 0.5f * kg * Mathf.Pow(v, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
