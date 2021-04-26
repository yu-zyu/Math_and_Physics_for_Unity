using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransposeMatrixof3X3TypeMatrix : MonoBehaviour
{
    public float[,] B = new float[,] {
        { 1, 4, 7 },
        { 2, 5, 8 },
        { 3, 6, 9 }
    };

    public float[,] X = new float[,] {
        { 0, 0, 0 },
        { 0, 0, 0 },
        { 0, 0, 0 }
    };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                X[i, j] = B[j, i];
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log(X[i, j]);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
