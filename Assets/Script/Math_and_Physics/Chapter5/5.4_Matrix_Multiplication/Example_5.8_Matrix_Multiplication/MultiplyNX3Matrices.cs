using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyNX3Matrices : MonoBehaviour
{
    public float[,] A = new float[,] {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
    };

    public float[] B = new float[] {
         1, 2, 3 
    };

    public float[] X = new float[] {
         0, 0, 0
    };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                X[i] += A[i, j] * B[j];
            }
        }

        for (int i = 0; i < 3; i++)
        {
            Debug.Log(X[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
