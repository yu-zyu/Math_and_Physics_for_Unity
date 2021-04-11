using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadianToDegree : MonoBehaviour
{
    public float Degree;
    public float[] Radian = new float[2];
    float pi = 3.141592654f;

    // Start is called before the first frame update
    void Start()
    {
        Degree = ((Radian[1]) / Radian[0]) * (180);
        Debug.Log(Degree);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
