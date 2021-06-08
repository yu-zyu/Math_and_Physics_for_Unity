using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletelyInelasticCollision : MonoBehaviour
{
    public float p1lbs;
    public float p2lbs;
    public float n1;
    public float m1;
    public float w;
    public float g;
    public float m2;
    public Vector2 v1i;
    public Vector2 v2i;
    public Vector2 v1f;
    public Vector2 v2f;
    public Vector2 vf;

    // Start is called before the first frame update
    void Start()
    {
        w = p1lbs / n1;
        m1 = w / g;

        w = p2lbs / n1;
        m2 = w / g;

        vf = ((m1 * v1i) + (m2 * v2i)) / (m1 + m2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
