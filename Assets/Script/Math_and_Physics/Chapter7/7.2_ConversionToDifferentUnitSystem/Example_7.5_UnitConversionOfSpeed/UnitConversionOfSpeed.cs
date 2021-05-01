using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitConversionOfSpeed : MonoBehaviour
{
    public float mi;
    public float result;

    // Start is called before the first frame update
    void Start()
    {
        result = UnitConversion.ConvertSpeed(mi);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
