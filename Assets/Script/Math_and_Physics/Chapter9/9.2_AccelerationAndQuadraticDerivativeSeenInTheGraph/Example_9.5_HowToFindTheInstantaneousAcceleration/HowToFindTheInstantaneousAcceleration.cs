using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToFindTheInstantaneousAcceleration : MonoBehaviour
{
    public float time;
    public float timeLimit;
    public int timeCount;
    public int a;
    public int b;
    public int h;
    public float averageAcceleration;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        if (timeLimit < time)
        {
            time = 0;
            timeCount++;
            timeCount = 0;
        }


        averageAcceleration = (f(3 + h) - f(3)) / h;
        
        
    }

    float f(float t)
    {
        return -9.8f * t + 25;
    }
}
