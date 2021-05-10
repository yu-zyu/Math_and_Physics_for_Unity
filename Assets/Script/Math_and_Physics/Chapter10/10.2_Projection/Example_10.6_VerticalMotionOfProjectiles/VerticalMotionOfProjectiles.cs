using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMotionOfProjectiles : MonoBehaviour
{
    public float vi;
    public float vf;
    public float t;
    public float a;
    public Transform cannon;
    public float deltaTime;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        t = (vf - vi) / a;
        t = t * 2;
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
