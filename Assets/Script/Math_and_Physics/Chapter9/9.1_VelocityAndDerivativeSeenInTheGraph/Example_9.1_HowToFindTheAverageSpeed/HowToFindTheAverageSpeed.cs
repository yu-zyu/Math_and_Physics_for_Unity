using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToFindTheAverageSpeed : MonoBehaviour
{
    public float v;
    //public float a;
    public float b;
    public float aa;
    public float time;
    public float timeLimit;
    public float timeCount;
    public float stop;
    public GameObject target;

    public float a;
    public float h;
    public float k;
    public float t;
    public float resutlT;
    public LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(timeLimit < time)
        {
            timeCount++;
            float x = timeCount/ 3; 
            float y = a * Mathf.Pow(x - h, 2) + k;
            target.transform.position = new Vector3(x, y, 0);
            Debug.Log(time);
            time = 0;
        }

        if (stop < timeCount)
        {
            target.transform.position = new Vector3(0, 0, 0);
            timeCount = 0;
        }
        resutlT = f(t);

        v = (f(b) - f(aa)) / (b - aa);
        lineRenderer.SetPosition(0, new Vector3(b,f(b), 0));
        lineRenderer.SetPosition(1, new Vector3(aa,f(aa), 0));
    }

    float f(float t)
    {
        float y = a * Mathf.Pow(t - h, 2) + k;
        return y;
    }

}
