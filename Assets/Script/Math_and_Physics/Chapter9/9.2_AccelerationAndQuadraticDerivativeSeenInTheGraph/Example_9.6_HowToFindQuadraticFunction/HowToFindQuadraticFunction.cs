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
        f(10, -4.9f);
        Debug.Log(dict["a"]);
        Debug.Log(dict["b"]);
        Debug.Log(dict["c"]);
    }

    // Update is called once per frame
    void Update()
    {


    }

     void f(float a, float b)
    {
        dict.Add("a", a);
        dict.Add("b", b*2);
        dict.Add("c", b);
    }

    float fff(float tt,float t2)
    {
        return tt * (t2);

    }
}
