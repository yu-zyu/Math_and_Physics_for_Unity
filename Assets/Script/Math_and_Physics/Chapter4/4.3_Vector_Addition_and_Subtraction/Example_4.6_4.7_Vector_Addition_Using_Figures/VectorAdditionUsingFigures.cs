using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorAdditionUsingFigures : MonoBehaviour
{
    public float a1_y;
    public float a1_x;
    public float b1;
    public GameObject straightLine1;
    public float a2_y;
    public float a2_x;
    public float b2;
    public GameObject straightLine2;
    public bool isMoveStraight = false;
    public Vector3 firstChild1;
    public Vector3 lastChild1;
    public Vector3 lastChild2;
    public GameObject straightLine3;
    public float a3_x;
    public float a3_y;
    public float a3;
    public float b3;

    // Start is called before the first frame update
    void Start()
    {
        straightLine1 = new GameObject();
        straightLine2 = new GameObject();
        straightLine3 = new GameObject();

        for (int i = 0; i < a1_x+1; i++)
        {
            var straightLine1_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            straightLine1_cube.transform.parent = straightLine1.transform;
        }

        for (int i = 0; i < a2_x+1; i++)
        {
            var straightLine2_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            straightLine2_cube.transform.parent = straightLine2.transform;
        }

         a3_x = a1_x + a2_x;
         a3_y = a1_y + a2_y;
         a3 = a3_y / a3_x;
        for (int j = 0; j < a3_x+1; j++)
        {
            var straightLine3_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            straightLine3_cube.transform.parent = straightLine3.transform;
        }
    }


    // Update is called once per frame
    void Update()
    {

        //foreach(var straightLine in straightLine1.transform)
        for(int i =0; i<straightLine1.transform.childCount; i++)
        {
            float a = a1_y / a1_x;
            float y = a * i + b1;
            var child = straightLine1.transform.GetChild(i);
            child.transform.position = new Vector3(i, y, 0);
            if (i == 0)
            {
                firstChild1 = child.transform.position;
            }
            lastChild1 = child.transform.position;
        }

        for(int i =0; i<straightLine2.transform.childCount; i++)
        {
            float a = a2_y / a2_x;
            float y = a * i + b2;
            var child = straightLine2.transform.GetChild(i);
            if (isMoveStraight)
            {

                child.transform.position = new Vector3(i + lastChild1.x, y + lastChild1.y, 0);
                for(int j=0; j<a3_x+1; j++)
                {
                    var child3 = straightLine3.transform.GetChild(j);
                    float a3y = a3 * j + b3;
                    child3.transform.position = new Vector3(j, a3y, 0);
                }

            }
            else
            {
                child.transform.position = new Vector3(i, y, 0);
                lastChild2 = child.transform.position;
            }
        }
    }
}
