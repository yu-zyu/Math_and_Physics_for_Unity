using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDirectionOfForceIsFree : MonoBehaviour
{
    public Vector2 f;
    public Vector2 deltaR;
    public float Frdot;
    public float FrSize;
    public float FrAngle;
    public float combinedForceF;
    public float combinedForceR;
    public float Fangle;
    public float Rangle;
    public Vector2 deltaRnormaliz;
    public float w;

    // Start is called before the first frame update
    void Start()
    {
        f = new Vector2(
            combinedForceF * Mathf.Cos(Fangle * Mathf.Deg2Rad),
            combinedForceF * Mathf.Sin(Fangle * Mathf.Deg2Rad)
            );

        deltaR = new Vector2(
            combinedForceR * Mathf.Cos(Rangle * Mathf.Deg2Rad),
            combinedForceR * Mathf.Sin(Rangle * Mathf.Deg2Rad)
            );

        deltaRnormaliz = deltaR / combinedForceR;
        Frdot = Vector2.Dot(f , deltaRnormaliz);
        Vector2 fr = Frdot * deltaRnormaliz;
        FrSize =  Mathf.Sqrt(Mathf.Pow(fr.x, 2) + Mathf.Pow(fr.y, 2));
        FrAngle =  Mathf.Atan(fr.y / fr.x)* Mathf.Rad2Deg;

        w = FrSize * combinedForceR;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
