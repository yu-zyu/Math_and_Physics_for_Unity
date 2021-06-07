using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseAndMomentumTheorem : MonoBehaviour
{
    public float m;
    public Vector3 impulse;
    public Vector3 v;
    public Vector3 vi;

    // Start is called before the first frame update
    void Start()
    {
       v = (impulse - (m * vi)) / m;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
