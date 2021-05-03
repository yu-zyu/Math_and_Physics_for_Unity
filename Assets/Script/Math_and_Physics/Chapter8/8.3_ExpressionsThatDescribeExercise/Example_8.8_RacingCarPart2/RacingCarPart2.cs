using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingCarPart2 : MonoBehaviour
{
    public float vf;
    public float vi;
    public float a;
    public float t;
    public float x;

    // Start is called before the first frame update
    void Start()
    {
        x = (-1 * Mathf.Pow(vi, 2)) / (2 * a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
