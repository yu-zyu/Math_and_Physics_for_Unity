using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixScalarTimes : MonoBehaviour
{
    public float[,] B = new float[,] {
        { 3, 6, -4 },
        { 0, -1, 2 }
    };

    public float[,] C = new float[,] {
        { 0, 0, 0 },
        { 0, 0, 0 }
    };

    public float scale;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                C[i, j] = B[i, j] * scale;
                Debug.Log(C[i, j]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
