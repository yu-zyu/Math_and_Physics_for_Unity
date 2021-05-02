using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionOfUnitsUsedInComputers : MonoBehaviour
{
    public float gb;
    public float result;
    // Start is called before the first frame update
    void Start()
    {
        result = gb * 1024 * 1024 * 1024 * 8;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
