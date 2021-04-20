using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorAdditionUsingFigures3D : MonoBehaviour
{
    public float a1_x;
    public float a1_y;
    public float a1_z;
    public float b1;
    public GameObject straightLine1;
    public float a2_x;
    public float a2_y;
    public float a2_z;
    public float b2;
    public GameObject straightLine2;
    public GameObject straightLine3;
    public float a3_x;
    public float a3_y;
    public float a3_z;
    public float a3;
    public float b3;
    public float z3;
    public bool isMinus = false;
    public Vector3 lastChild1;

    // Start is called before the first frame update
    void Start()
    {
        straightLine1 = new GameObject();
        straightLine2 = new GameObject();
        straightLine3 = new GameObject();

        for (int i = 0; i < 10; i++)
        {
            var straightLine1_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            straightLine1_cube.transform.parent = straightLine1.transform;
        }

        if (isMinus)
        {
            a2_x = -a2_x;
            a2_y = -a2_y;
            a2_z = -a2_z;

        }

        for (int i = 0; i < 10; i++)
        {
            var straightLine2_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            straightLine2_cube.transform.parent = straightLine2.transform;
        }

 
        a3_x = a1_x + a2_x;
        a3_y = a1_y + a2_y;
        a3_z = a1_z + a2_z;

        for (int j = 0; j < 10; j++)
        {
            var straightLine3_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            straightLine3_cube.transform.parent = straightLine3.transform;
        }

        for(int i =0; i<straightLine1.transform.childCount; i++)
        {
            var child = straightLine1.transform.GetChild(i);
            child.transform.position = new Vector3(a1_x * i, a1_y * i, a1_z * i);
            lastChild1 = child.transform.position;
        }

        for(int i =0; i<straightLine2.transform.childCount; i++)
        {
            var child = straightLine2.transform.GetChild(i);
            child.transform.position = new Vector3(lastChild1.x + a2_x * i, lastChild1.y + a2_y * i, lastChild1.z + a2_z * i);
        }

        for(int i =0; i<straightLine3.transform.childCount; i++)
        {
            var child = straightLine3.transform.GetChild(i);
            child.transform.position = new Vector3(a3_x * i, a3_y * i, a3_z * i);
        }

    }


    // Update is called once per frame
    void Update()
    {

    }
}
