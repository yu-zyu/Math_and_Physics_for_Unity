using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasesThatUseTwoOrMoreFormulas : MonoBehaviour
{
    public float vf;
    public float vi;
    public float a;
    public float t;
    public float x;

    // Start is called before the first frame update
    void Start()
    {
        vf = Mathf.Sqrt(Mathf.Pow(vi, 2) + (2*a)*(x));
        t = (vf - vi) / a;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
