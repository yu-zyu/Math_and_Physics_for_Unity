using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionFromMetersToKilometers : MonoBehaviour
{
    public float meter;
    public float kiloMeters;
    public float resultKiloMeters;
    public float resultMeters;

    // Start is called before the first frame update
    void Start()
    {
        float kilo = meter * 0.001f;
        resultKiloMeters = kilo + kiloMeters;
        resultMeters = resultKiloMeters * 1000; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConvertToMeter()
    {
    }
}
