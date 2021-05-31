using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkAndKineticEnergy : MonoBehaviour
{
    public float w;
    public float power;
    public float motionFriction;
    public float f;
    public float deltaX;

    // Start is called before the first frame update
    void Start()
    {
        f = power - motionFriction;
        w = f * deltaX;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
