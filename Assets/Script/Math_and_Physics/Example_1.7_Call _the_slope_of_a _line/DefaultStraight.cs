using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultStraight : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    public float m;
    // Start is called before the first frame update
    void Start()
    {
        m = -a / b;
        Debug.Log("直線の傾き: " + m);
        
    }

    public float getIntercept()
    {
        return  c / b;
    }


}
