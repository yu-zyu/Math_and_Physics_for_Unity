using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixAddition : MonoBehaviour
{
    public float[,] A = new float[,] {
        { 1, 4, 7 },
        { 2, 5, 8 },
        { 3, 6, 9 }
    };

    public float[,] B = new float[,] {
        { -3, 9, 4 },
        { 0, 1, -1 },
        { 5, -2, 0 }
    };

    public float[,] AB = new float[,] {
        { 0, 0, 0 },
        { 0, 0, 0 },
        { 0, 0, 0 }
    };

    public bool isMinus;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (isMinus)
                {
                    AB[i, j] = A[i, j] - B[i, j];
                }
                else
                {
                    AB[i, j] = A[i, j] + B[i, j];
                }

                Debug.Log(AB[i, j]);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
