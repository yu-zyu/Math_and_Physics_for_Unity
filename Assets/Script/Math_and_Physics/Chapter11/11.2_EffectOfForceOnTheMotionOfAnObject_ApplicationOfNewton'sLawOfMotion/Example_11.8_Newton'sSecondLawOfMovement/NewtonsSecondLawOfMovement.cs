using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtonsSecondLawOfMovement : MonoBehaviour
{
    public float w;
    public float m;
    public float g;
    public Vector2 a;
    public Vector2 fnet;

    // Start is called before the first frame update
    void Start()
    {
        //w = mg
        m = w / g;

        // fnet = m * a;
        a = fnet / m;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
