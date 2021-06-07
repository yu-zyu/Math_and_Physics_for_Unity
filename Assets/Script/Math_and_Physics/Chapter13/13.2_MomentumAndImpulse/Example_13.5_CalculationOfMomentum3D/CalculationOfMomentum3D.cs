using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationOfMomentum3D : MonoBehaviour
{
    public float m;
    public Vector3 v;
    public Vector3 p;

    // Start is called before the first frame update
    void Start()
    {
        p = m * v;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
