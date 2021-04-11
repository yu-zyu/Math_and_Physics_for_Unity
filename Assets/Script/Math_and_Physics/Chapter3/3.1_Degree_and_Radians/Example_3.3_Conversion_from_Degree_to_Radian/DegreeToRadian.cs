using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegreeToRadian : MonoBehaviour
{

    public float Degree;
    public float Radian;
    float pi = 3.141592654f;


    // Start is called before the first frame update
    void Start()
    {
        Radian = Degree * pi / 180;
        Debug.Log(Radian);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
