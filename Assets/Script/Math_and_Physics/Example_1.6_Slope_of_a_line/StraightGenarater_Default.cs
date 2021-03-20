using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightGenarater_Default : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    public bool isGenarete;

    // Update is called once per frame
    void Update()
    {

        if (isGenarete)
        {
            // すべての子オブジェクトを取得して削除
            foreach (Transform childTransform in gameObject.transform)
            {
                GameObject.Destroy(childTransform.gameObject);
            }

            for (int i = 0; i < 10; i++)
            {
                float x = i;
                float y = i;
                y = (-(a * x) + c)/b;
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(x, y, 0);
                    cube.transform.parent = gameObject.transform;
                    Debug.Log(y);
            }
            isGenarete = false;
        }
    }
}
