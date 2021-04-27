using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransposeMatrix : MonoBehaviour
{
    public float[,] D = new float[,] {
        { 2, -1, 3, 8 },
        { 0,  5, 1, 4 }
    };

    public float[,] X = new float[,] {
        { 0, 0 },
        { 0, 0 },
        { 0, 0 },
        { 0, 0 }
    };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                X[j,i] = D[i,j];
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
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
