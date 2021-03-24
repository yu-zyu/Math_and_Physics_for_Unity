using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightGenarater : MonoBehaviour
{
    public float a;
    public float b;
    public bool isGenarete;
    public GameObject straightLine;
    public List<Vector3> childrenPosition;

    // Update is called once per frame
    void Update()
    {

        if (isGenarete)
        {

            if(straightLine == null)
            {
                straightLine = GameObject.CreatePrimitive(PrimitiveType.Cube);
            }
            // すべての子オブジェクトを取得して削除
            foreach (Transform childTransform in straightLine.transform)
            {
                GameObject.Destroy(childTransform.gameObject);
            }

            for (int i = 0; i < 50; i++)
            {
                float x = i;
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                float y = (a * x) + b;
                cube.transform.position = new Vector3(x, y, 0);
                cube.transform.parent = straightLine.transform;
                childrenPosition.Add(cube.transform.position);
                Debug.Log(y);
            }

            isGenarete = false;
        }

    }

}
