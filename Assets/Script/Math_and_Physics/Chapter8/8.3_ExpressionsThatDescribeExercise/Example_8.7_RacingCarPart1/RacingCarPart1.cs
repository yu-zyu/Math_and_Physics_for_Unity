using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingCarPart1 : MonoBehaviour
{

    public float vf;
    public float vi;
    public float a;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        t = (-vi -vf) / a;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
