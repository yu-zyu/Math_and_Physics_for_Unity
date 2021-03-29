using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionTwoStraightLines : MonoBehaviour
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
        else
        {
            if(straightLine1.getIntercept() != straightLine2.getIntercept())
            {
                Debug.Log("解はゼロです");
            }
            else
            {
                Debug.Log("解は無限個です");
            }

        }

        GenerateLine("straight1List", straightLine1);
        GenerateLine("straight2List", straightLine2);
    }

    void GenerateLine(string lineName, DefaultStraight defaultStraight)
    {
        GameObject straight2List = GameObject.CreatePrimitive(PrimitiveType.Cube);
        straight2List.name = lineName;

        for (int i = 0; i < 100; i++)
        {
            float x = i;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            float y = (defaultStraight.m * x) + defaultStraight.getIntercept();
            cube.transform.position = new Vector3(x, y, 0);
            cube.transform.parent = straight2List.transform;
        }
    }
}
