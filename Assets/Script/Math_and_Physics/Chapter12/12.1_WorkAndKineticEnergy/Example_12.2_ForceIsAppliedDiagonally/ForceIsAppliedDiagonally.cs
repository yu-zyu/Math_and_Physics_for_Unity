using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceIsAppliedDiagonally : MonoBehaviour
{
    public float f;
    public float fx;
    public float angle;
    public float combinedForce;
    public float motionFriction;
    public float w;
    public float deltaX;

    // Start is called before the first frame update
    void Start()
    {
        fx = f * Mathf.Cos(angle * Mathf.Deg2Rad);
        combinedForce = fx - motionFriction;
        w = combinedForce * deltaX;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
