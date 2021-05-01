using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionFromMetersToKilometers : MonoBehaviour
{
    public float meter;
    public float kiloMeters;
    public float resultKiloMeters;

    // Start is called before the first frame update
    void Start()
    {
        float kilo = meter * 0.01f;
        resultKiloMeters = kilo + kiloMeters;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
