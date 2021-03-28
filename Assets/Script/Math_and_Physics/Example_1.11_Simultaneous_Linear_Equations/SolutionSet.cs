using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionSet : MonoBehaviour
{
    public DefaultStraight straightLine1;
    public DefaultStraight straightLine2;

    // Start is called before the first frame update
    void Start()
    {
        if(straightLine1.m != straightLine2.m)
        {
            Debug.Log("交点は1つです");
        }

        GenerateLine("straight1List", straightLine1.m);
        GenerateLine("straight2List", straightLine2.m);
    }

    void GenerateLine(string lineName, float slope)
    {
        GameObject straight2List = GameObject.CreatePrimitive(PrimitiveType.Cube);
        straight2List.name = lineName;

        for (int i = 0; i < 100; i++)
        {
            float x = i;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            float y = slope * (x - gameObject.transform.position.x) + gameObject.transform.position.y;
            cube.transform.position = new Vector3(x, y, 0);
            cube.transform.parent = straight2List.transform;
        }
    }
}
