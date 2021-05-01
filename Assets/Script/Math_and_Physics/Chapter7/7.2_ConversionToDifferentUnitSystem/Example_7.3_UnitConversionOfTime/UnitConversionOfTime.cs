using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitConversionOfTime : MonoBehaviour
{
    public int week;
    public float result;
        
    // Start is called before the first frame update
    void Start()
    {
        float day = week * 7;
        result = UnitConversion.ConvertDaysToSeconds(day);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
