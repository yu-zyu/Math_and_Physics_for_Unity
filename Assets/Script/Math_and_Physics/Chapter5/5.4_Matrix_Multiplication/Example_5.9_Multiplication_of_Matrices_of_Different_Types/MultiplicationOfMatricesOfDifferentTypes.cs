using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationOfMatricesOfDifferentTypes : MonoBehaviour
{
    public float[,] B = new float[,] {
        { 1, 2, 3 }
    };

    public float[,] A = new float[,] {
        { 4, 3, -2 },
        {  -1, 0, 5 }
    };

    // Start is called before the first frame update
    void Start()
    {
        if(B.GetLength(0) == B.GetLength(1))
        {
            Debug.Log("Bの列数とAの行数が一致します");

        }
        else
        {
            Debug.Log("Bの列数とAの行数が一致しません");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
