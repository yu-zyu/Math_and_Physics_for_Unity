using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageAngularAccelerationOfWheels : MonoBehaviour
{
    public float alpha;
    public float startT;
    public float endT;
    public float startOmega;
    public float endOmega;

    // Start is called before the first frame update
    void Start()
    {
        alpha = (endOmega - startOmega) / (endT - startT);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
