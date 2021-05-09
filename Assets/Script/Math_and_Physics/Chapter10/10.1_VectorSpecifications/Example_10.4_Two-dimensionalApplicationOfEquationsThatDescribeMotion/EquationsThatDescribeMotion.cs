using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationsThatDescribeMotion : MonoBehaviour
{
    public Vector3 vf;
    public Vector3 vi;
    public float t;
    public Vector3 a;
    public Transform car;
    public float deltaTime;
    public bool isChange;
    // Start is called before the first frame update
    void Start()
    {
        vf = vi + (a * t);
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += Time.deltaTime;
        if (1 <= deltaTime)
        {
            if (isChange)
            {
                car.position += vf;

            }
            else
            {
                car.position += vi;
            }

            deltaTime = 0;
        }
    }
}
