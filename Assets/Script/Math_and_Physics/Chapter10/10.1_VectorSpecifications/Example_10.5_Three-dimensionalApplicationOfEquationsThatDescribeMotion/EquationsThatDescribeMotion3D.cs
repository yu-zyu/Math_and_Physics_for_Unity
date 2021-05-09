using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationsThatDescribeMotion3D : MonoBehaviour
{
    public Vector3 x;
    public Vector3 vi;
    public float t;
    public Vector3 a;
    public Transform car;
    public float deltaTime;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        x = (vi * t) + (a * Mathf.Pow(t, 2)) / 2;
    }

    // Update is called once per frame
    void Update()
    {
       // deltaTime += Time.deltaTime;
       // if (1 <= deltaTime)
       // {
       //     time++;
       //     car.position += a;
       //     deltaTime = 0;
       // }
    }
}
