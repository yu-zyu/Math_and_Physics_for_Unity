using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToFindTheAverageAcceleration : MonoBehaviour
{
    public float[] speed = {
        0,3,12,27,48,75,108
    };

    public GameObject car;
    public float time;
    public float timeLimit;
    public int timeCount;
    public int a;
    public int b;
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
            car.transform.position = new Vector3(speed[timeCount], 0, 0);
            time = 0;
            timeCount++;
            if(speed.Length <= timeCount)
            {
                timeCount = 0;
            }
        }


        averageAcceleration = (f(b) - f(a)) / (b - a);
        
        
    }

    float f(int x)
    {
        return speed[x];
    }
}
