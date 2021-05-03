using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float vf;
    public float vi;
    public float a;
    public float t2;
    public float t;
    public float x;

    // Start is called before the first frame update
    void Start()
    {
        a = a / 2;
        t2 = (x + vi) / a;
        t = Mathf.Sqrt(t2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
