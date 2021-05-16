using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMotionOfProjectiles : MonoBehaviour
{
    public float v;
    public float x;
    public float t;
    public float a;
    public Transform cannon;
    public float deltaTime;
    public float time;
    public float doo;
    // Start is called before the first frame update
    void Start()
    {
        x = v * t;
    }

    // Update is called once per frame
    void Update()
    {
        //deltaTime += Time.deltaTime;
        //if (0.4 <= deltaTime)
        //{
        //    time++;
        //    float sin = Mathf.Sin((doo * Mathf.Deg2Rad)* time*10);
        //    float cos = Mathf.Cos((doo * Mathf.Deg2Rad)* time*10);
        //    cannon.position = new Vector3(cos, sin, 0);
        //    deltaTime = 0;
        //}
    }
}
