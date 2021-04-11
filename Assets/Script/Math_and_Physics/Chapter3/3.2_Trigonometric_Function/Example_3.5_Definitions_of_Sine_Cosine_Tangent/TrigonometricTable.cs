using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigonometricTable : MonoBehaviour
{
    public float RadToDeg = 57.29577951f;
    public float DegToRad = 0.017453293f;
    public float[] sin_table = new float[360];
    public float[] cos_table = new float[360];
    public float[] tan_table = new float[360];


    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i<360; i++)
        {
            sin_table[i] = Mathf.Sin(i * DegToRad);
            cos_table[i] = Mathf.Cos(i * DegToRad);
            tan_table[i] = Mathf.Tan(i * DegToRad);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
