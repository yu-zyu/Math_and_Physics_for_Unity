using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElasticCollision : MonoBehaviour
{
    public float m1;
    public float m2;
    public Vector2 v1i;
    public Vector2 v2i;
    public Vector2 v1f;
    public Vector2 v2f;
    public Vector2 minusV;
    public Vector2 pluseV;
    public float e;
    public List<Vector2> formulaA;
    public List<Vector2> formulaB;
    public List<Vector2> resultFormula;

    // Start is called before the first frame update
    void Start()
    {
        //(m1 * v1i) + 
        formulaA.Add(v1f);
        formulaA.Add(v2f);
        formulaB.Add(v1f);
        formulaB.Add(-v2f);
        pluseV = v1i + v2i;
        formulaA.Add(pluseV);
        minusV = -e * (v1i - v2i);
        formulaB.Add(minusV);

        formulaA[1] = new Vector2(1,1);
        formulaB[1] = new Vector2(-1,-1);
        for(int i=0; i<formulaA.Count; i++)
        {
            resultFormula.Add(formulaA[i] - formulaB[i]);
        }

        v2f = resultFormula[2] / resultFormula[1];
        v1f = formulaA[2] - v2f;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
