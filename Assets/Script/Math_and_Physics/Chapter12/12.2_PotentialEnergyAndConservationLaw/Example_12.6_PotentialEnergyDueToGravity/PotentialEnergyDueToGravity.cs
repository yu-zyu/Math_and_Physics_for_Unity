using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotentialEnergyDueToGravity : MonoBehaviour
{
    public float lbs;
    public float n1;
    public float n;
    public float w;
    public float m;
    public float g;
    public float pe;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        n = lbs / n1;
        m = n / g;
        pe = m * g * y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
