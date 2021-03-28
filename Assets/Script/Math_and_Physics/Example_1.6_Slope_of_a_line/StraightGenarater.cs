using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightGenarater : MonoBehaviour
{
    public float a;
    public float b;
    public float x1;
    public float y1;
    public bool isGenarete;
    public GameObject straightLine;
    public List<Vector3> childrenPosition;
    public bool IsVerticalStraightLine = false;

    // Update is called once per frame
    void Update()
    {

        if (isGenarete)
        {

            if (straightLine == null)
            {
                straightLine = GameObject.CreatePrimitive(PrimitiveType.Cube);
            }
            // すべての子オブジェクトを取得して削除
            foreach (Transform childTransform in straightLine.transform)
            {
                GameObject.Destroy(childTransform.gameObject);
                childrenPosition.Clear();
            }

            for (int i = 0; i < 50; i++)
            {
                float x = i;
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

                float y = (a * x) + b;
                if (IsVerticalStraightLine)
                {
                    float m = Math_and_PhysicsLib.perpSlope(a);
                    y = m * (x - x1) + y1;
                }
                cube.transform.position = new Vector3(x, y, 0);
                cube.transform.parent = straightLine.transform;
                childrenPosition.Add(cube.transform.position);

                //今の自分の地点まで直線を生成したら終わり
                if (x1 == x && y1 == y)
                {
                    //配列をリバースして移動しやすいようにする
                    if (IsVerticalStraightLine)
                        childrenPosition.Reverse();
                    isGenarete = false;
                    return;
                }
                Debug.Log(y);
            }
            isGenarete = false;
        }

    }

}
