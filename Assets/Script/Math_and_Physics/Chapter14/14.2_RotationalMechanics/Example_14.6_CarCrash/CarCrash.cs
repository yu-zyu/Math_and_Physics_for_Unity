using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrash : MonoBehaviour
{
    public float r;
    public float a;
    public float i;

    // Start is called before the first frame update
    void Start()
    {
        //r = Ia
        a = r / i;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
