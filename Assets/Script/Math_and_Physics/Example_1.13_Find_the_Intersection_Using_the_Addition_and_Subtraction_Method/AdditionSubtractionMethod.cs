using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionSubtractionMethod : MonoBehaviour
{
    public float p1_a;
    public float p1_b;
    public float p1_c;

    public float p2_a;
    public float p2_b;
    public float p2_c;
    // Start is called before the first frame update
    void Start()
    {
        float p1_aResult = p2_a * (p1_a);
        float p1_bResult = p2_a * (p1_b);
        float p1_cResult = p2_a * (p1_c);

        float p2_aResult = p1_a * (p2_a);
        float p2_bResult = p1_a * (p2_b);
        float p2_cResult = p1_a * (p2_c);

        float y = (p1_cResult - p2_cResult) / (p1_bResult - p2_bResult);
        float x = p2_c - (p2_b * y) / p2_a;

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, 0);
        Debug.Log(cube.transform.position);
    }
}
