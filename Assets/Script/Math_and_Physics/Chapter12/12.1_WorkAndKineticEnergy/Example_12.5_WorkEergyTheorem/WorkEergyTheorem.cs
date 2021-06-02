using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkEergyTheorem : MonoBehaviour
{
    public float f;
    public float deltaX;
    public float m;
    public float j;
    public float vf;


    // Start is called before the first frame update
    void Start()
    {
        m = m / 1000;
        j = f * deltaX;
        vf = Mathf.Sqrt(j / (0.5f * m));
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
