using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Tilt_Unity tilt_unity;
    public float p1_x;
    public float p1_y;
    public float m;
    public bool isGenerateStraight;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (isGenerateStraight)
        {
            // すべての子オブジェクトを取得して削除
            foreach (Transform childTransform in gameObject.transform)
            {
                GameObject.Destroy(childTransform.gameObject);
            }

            p1_x = tilt_unity.P1[0];
            p1_y = tilt_unity.P1[1];

            for (int x = (int)p1_x + 1; x < tilt_unity.P2[0]; x++)
            {
                float y = tilt_unity.m * (x - p1_x) + p1_y;
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, y, 0);
                cube.transform.parent = gameObject.transform;
               // gameObject.transform.position = new Vector3(x, y, 0);

            }
            isGenerateStraight = false;
        }

    }
}
