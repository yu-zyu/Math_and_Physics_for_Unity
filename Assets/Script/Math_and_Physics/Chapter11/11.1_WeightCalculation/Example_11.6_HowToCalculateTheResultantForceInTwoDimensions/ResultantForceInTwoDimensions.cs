using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultantForceInTwoDimensions : MonoBehaviour
{
    public float n1;
    public Vector2 fr;
    public float pull;
    public float pullAngle;
    public float fk;
    public float n;
    public float u;
    public float lbs;
    public Vector2 w;
    public Vector2 normalForce;
    public Vector2 combinedForce;

    // Start is called before the first frame update
    void Start()
    {
        w = new Vector2(0, lbs / n1);
        fr = new Vector2(pull * Mathf.Cos(pullAngle * Mathf.Deg2Rad), pull * Mathf.Sin(pullAngle * Mathf.Deg2Rad));
        normalForce = w + fr;
        ///combinedForce = w + fr + n + fk;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
