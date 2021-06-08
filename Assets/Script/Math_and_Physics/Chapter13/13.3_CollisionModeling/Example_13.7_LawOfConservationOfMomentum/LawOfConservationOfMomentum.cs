using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LawOfConservationOfMomentum : MonoBehaviour
{
    public float m1;
    public Vector3 v1i;
    public float m2;
    public Vector3 v2i;
    public Vector3 v1f;
    public Vector3 v2f;

    // Start is called before the first frame update
    void Start()
    {
        v2f = ((m1 * v1i) + (m2 * v2i) - (m1 * v1f)) / m2; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
