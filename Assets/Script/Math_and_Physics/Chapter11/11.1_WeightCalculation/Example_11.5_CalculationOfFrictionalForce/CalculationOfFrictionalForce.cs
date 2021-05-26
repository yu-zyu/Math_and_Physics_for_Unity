using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationOfFrictionalForce : MonoBehaviour
{

    public float lbs;
    public float n1;
    public float n;
    public float normalForce;
    public float staticFunction;
    public float dynamicFunction;
    public float us;
    public float uk;
    public float fs;
    public float fk;

    // Start is called before the first frame update
    void Start()
    {
        n = lbs / n1;
        normalForce = Mathf.Abs(n);
        fs = us * n;
        fk = uk * n;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
