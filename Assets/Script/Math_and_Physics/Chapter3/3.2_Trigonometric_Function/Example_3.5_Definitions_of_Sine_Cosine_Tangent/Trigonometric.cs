using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigonometric : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    public float sinA;
    public float cosA;
    public float tanA;
    public float cscA;
    public float secA;
    public float cotA;


    // Start is called before the first frame update
    void Start()
    {
        c = Mathf.Sqrt(Mathf.Pow(a, 2) + Mathf.Pow(b, 2));
        sinA = b / c;
        cosA = a / c;
        tanA = b / a;

        cscA = 1 / sinA;
        secA = 1 / cosA;
        cotA = 1 / tanA;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
