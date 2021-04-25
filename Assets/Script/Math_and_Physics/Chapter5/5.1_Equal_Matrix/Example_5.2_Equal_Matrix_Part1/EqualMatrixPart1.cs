using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualMatrixPart1 : MonoBehaviour
{
    public float[,] C = new float[,] {
        { 1, 2, 3 },
        { 4, 5, 6 }
    };

    public float[,] D = new float[,] {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
    };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("型が違うので等しくない");
        
    }
}
