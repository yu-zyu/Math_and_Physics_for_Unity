using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceUnitConversion : MonoBehaviour
{
    public float mil;
    public float result;

    // Start is called before the first frame update
    void Start()
    {
        result = UnitConversion.ConvertMilesToMeters(mil);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
