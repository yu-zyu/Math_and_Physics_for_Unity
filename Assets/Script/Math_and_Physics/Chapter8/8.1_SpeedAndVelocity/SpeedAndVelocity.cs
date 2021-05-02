using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedAndVelocity : MonoBehaviour
{

    public float D;
    public float v;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        D = v * t;
        gameObject.transform.position += new Vector3(D,0,0);
    }
}
