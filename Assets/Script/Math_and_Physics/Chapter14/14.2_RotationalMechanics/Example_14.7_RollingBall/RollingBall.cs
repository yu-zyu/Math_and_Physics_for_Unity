using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    public float m;
    public float g;
    public float vI;
    public float vF;
    public float yI;
    public float yF;
    public float omegaI;
    public float omegaF;
    public float j;
    public float i;
    public float r;
    public float vf1;
    public float vf2;

    // Start is called before the first frame update
    void Start()
    {
        //KEr = 1/2 I omega^2
        //PEi + KEti + KEri = PEf + KEtf + KErf

        j = (m * g * yI);

        //KEr = 1/2 * I * omega^2
        //慣性モーメントIはmr^2だから
        //v = r * omegaなので、v^2 = r^2 * omega^2
        vf1 = m / 2;
        vf2 = (i * m) / 2;

        vF = Mathf.Sqrt(j / (vf1 + vf2));

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
