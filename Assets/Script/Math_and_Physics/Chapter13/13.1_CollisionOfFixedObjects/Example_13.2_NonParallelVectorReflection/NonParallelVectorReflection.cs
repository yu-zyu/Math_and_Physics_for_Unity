using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonParallelVectorReflection : MonoBehaviour
{
    public Vector2 boundary;
    public Vector2 normal;
    public Vector2 b;
    public Vector2 ballStart;
    public Vector2 ballEnd;
    public float size;
    public Vector2 normalDash;
    public Vector2 p;
    public Vector2 vi;
    public Vector2 vf;

    
    // Start is called before the first frame update
    void Start()
    {
        boundary = ballEnd - ballStart;
        normal = new Vector2(boundary.y, -boundary.x);
        size = Mathf.Sqrt(Mathf.Pow(normal.x, 2) + Mathf.Pow(normal.y, 2));
        normalDash = new Vector2(normal.x / size, normal.y / size);
        p = Vector2.Dot(-vi, normalDash) * normalDash;
        vf = 2 * p + vi;


        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
