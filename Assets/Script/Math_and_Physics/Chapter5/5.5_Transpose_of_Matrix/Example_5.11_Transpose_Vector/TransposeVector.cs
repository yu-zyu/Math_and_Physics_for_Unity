using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransposeVector : MonoBehaviour
{
    public float[,] C = new float[,] {
        { 1 },
        { 2 },
        { 3 }
    };

    public float[,] X = new float[,] {
        { 0, 0, 0 }
    };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
                X[0, i] = C[i, 0];
        }

        for (int i = 0; i < 3; i++)
        {
            Debug.Log(X[0,i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
