using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToFindQuadraticFunction : MonoBehaviour
{
    public float h;
    public float t;
    public float speed;
    public float ff;
    public float tt;
    public Dictionary<string,float> dict = new Dictionary<string, float>();


    // Start is called before the first frame update
    void Start()
    {
        //        tt = (f(t + h) - f(t)) / h;
        //ff = (f(tt + h) - f(tt)) / h;

        f(10, -4.9f);
        Debug.Log(dict["a"]);
        Debug.Log(dict["b"]);
        Debug.Log(dict["c"]);
    }

    // Update is called once per frame
    void Update()
    {


      //  ff = f(t + h) - f(t) / h;
      //  tt = fff(ff, t+h) - fff(ff, t) / h;
    }

    //float f(float tt, float hh)
     void f(float a, float b)
    {
        //a - (2 * b * t) - (b * h) / h;

        dict.Add("a", a);
        dict.Add("b", b*2);
        dict.Add("c", b);

        



        //return (10 * (tt + hh)) - (4.9f * (Mathf.Pow(tt,2) + Mathf.Pow(hh,2)+ 2*tt*hh));
        // float a = 10 - (-9.8f * t) - (4.9f * h);
        // float a = 10 - (-9.8f * (t + h)) - (10 - 9.8f * h);
        // float a = 10 - (aa * t) - (bb * h);
        //tt = (f(t + h) - f(t)) / h;
        // return (10 * x) - (4.9f * Mathf.Pow(x, 2));
    }

    float fff(float tt,float t2)
    {
        return tt * (t2);

    }
}
