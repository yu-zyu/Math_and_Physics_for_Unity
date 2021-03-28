using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool isMove;
    public StraightGenarater StraightGenarater;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (isMove)
        {
            StartCoroutine(Move());

            isMove = false;
        }

    }


    IEnumerator Move()
    {
        foreach (Vector3 childTransform in StraightGenarater.childrenPosition)
        {
            gameObject.transform.position = childTransform;

            //この座標に来たら直角を生成
            if (gameObject.transform.position == new Vector3(30, 40, 0))
            {
                if (!StraightGenarater.IsVerticalStraightLine)
                {
                    StraightGenarater.x1 = gameObject.transform.position.x;
                    StraightGenarater.y1 = gameObject.transform.position.y;
                    StraightGenarater.IsVerticalStraightLine = true;
                    StraightGenarater.isGenarete = true;
                    yield break;
                }
            }

            //今まで移動してきた経路を生成
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cube.transform.position = gameObject.transform.position;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
