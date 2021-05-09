using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplacementInTwoDimensions : MonoBehaviour
{
    public Transform targetA;
    public Transform targetB;
    public Vector3 displacement;

    // Start is called before the first frame update
    void Start()
    {
        displacement = targetB.position - targetA.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
