using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveFormulasThatDescribeMotion : MonoBehaviour
{
    public float w;
    public float lbs;
    public float n1;
    public float n;
    public float fkk;
    public Vector2 fk;
    public float uk;
    public float power;
    public float angle;
    public Vector2 fp;
    public Vector2 fnet;
    public float m;
    public float g;
    public Vector2 a;
    public Vector2 deltaR;
    public Vector2 vi;

    // Start is called before the first frame update
    void Start()
    {
        w = lbs / n1;
        n = Mathf.Abs(w);
        fkk = uk * n;
        fp.x = power * Mathf.Cos(angle * Mathf.Deg2Rad);
        fp.y = power * Mathf.Sin(angle * Mathf.Deg2Rad);
        fk.x = fkk * Mathf.Cos((angle + 180) * Mathf.Deg2Rad);
        fk.y = fkk * Mathf.Sin((angle + 180) * Mathf.Deg2Rad);
        fnet = fp + fk;
        m = w / g;
        a = fnet / m;

        for(int t=1; t < 4; t++)
        {
            //deltaR = vit + 1/2at^2
            deltaR = (vi * t) + a * Mathf.Pow(t, 2) / 2;
            Debug.Log(deltaR);
        }




        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
