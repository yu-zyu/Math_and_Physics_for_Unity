using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonParallelVector3Reflection : MonoBehaviour
{
    public Vector3 boundary;
    public Vector3 normal;
    public Vector3 b;
    public Vector3 ballStart;
    public Vector3 ballEnd;
    public float size;
    public Vector3 normalDash;
    public Vector3 p;
    public Vector3 vi;
    public Vector3 vf;

    
    // Start is called before the first frame update
    void Start()
    {
        //boundary = Vector3.Scale(ballEnd, ballStart);
        //normal = new Vector3(boundary.y, -boundary.x);
        normal = Vector3.Cross(ballEnd, ballStart);
        
        size = Mathf.Sqrt(Mathf.Pow(normal.x, 2) + Mathf.Pow(normal.y, 2) + Mathf.Pow(normal.z, 2));
        normalDash = new Vector3(normal.x / size, normal.y / size, normal.z / size);
        p = Vector3.Dot(-vi, normalDash) * normalDash;
        vf = 2 * p + vi;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
