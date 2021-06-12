using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseballPitching : MonoBehaviour
{
    public float vt;
    public float omega;
    public float r;
    public float t;
    public float a;
    public float at;

    // Start is called before the first frame update
    void Start()
    {
        //vt = omega * r
        at = a * r;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
