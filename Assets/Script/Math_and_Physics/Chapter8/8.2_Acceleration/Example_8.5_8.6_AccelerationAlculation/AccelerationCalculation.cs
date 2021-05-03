using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationCalculation : MonoBehaviour
{
    public float vf;
    public float vi;
    public float tf;
    public float ti;
    public float a1;
    public float a2;

    // Start is called before the first frame update
    void Start()
    {
        a1 = (vf - vi) / ((tf - ti) /(60 * 60));
        a2 = UnitConversion.ConvertAcelMilesToMeters(a1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
