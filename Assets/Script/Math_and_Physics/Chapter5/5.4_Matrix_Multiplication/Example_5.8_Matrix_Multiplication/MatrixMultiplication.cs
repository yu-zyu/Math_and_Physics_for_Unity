using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixMultiplication : MonoBehaviour
{
    public float[,] A = new float[,] {
        { 4, 5 },
        { 1, -2 }
    };

    public float[,] B = new float[,] {
        { 0, -1 },
        {  -3, 2 }
    };

    public float[,] X = new float[,] {
        { 0, 0 },
        { 0, 0 }
    };

    // Start is called before the first frame update
    void Start()
    {
         X[0,0] = (A[0, 0] * B[0, 0]) + (A[0,1] * B[1,0]);
         X[0,1] = (A[0, 0] * B[0, 1]) + (A[0,1] * B[1,1]);
         X[1,0] = (A[1, 0] * B[0, 0]) + (A[1,1] * B[1,0]);
         X[1,1] = (A[1, 0] * B[0, 1]) + (A[1,1] * B[1,1]);

        foreach(int x in X)
        {
            Debug.Log(x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
