using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultStraight : MonoBehaviour
{
    public float a;
    public float b;
    public float m;
    // Start is called before the first frame update
    void Start()
    {
        m = -a / b;
        Debug.Log("直線の傾き: " + m);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
