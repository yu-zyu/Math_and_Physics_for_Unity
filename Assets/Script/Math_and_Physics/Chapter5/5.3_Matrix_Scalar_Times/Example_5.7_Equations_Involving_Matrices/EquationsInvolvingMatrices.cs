using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationsInvolvingMatrices : MonoBehaviour
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

    public float aA;
    public float xX;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                X[i, j] = xX * (aA * A[i, j] - B[i, j]);
                Debug.Log(X[i, j]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
