using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTheCircleEquations : MonoBehaviour
{
    public Transform player;
    public Transform playerCircle;
    public float h;
    public float k;
    public float r;
    public LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //距離の公式を使って半径を求める
        r = Mathf.Pow(playerCircle.position.x - player.position.x, 2) + Mathf.Pow(playerCircle.position.y - player.position.y, 2);

        lineRenderer.SetPosition(0, player.position);
        lineRenderer.SetPosition(1, playerCircle.position);

        h = player.position.x;
        k = player.position.y;

        float sqrtR = Mathf.Sqrt(r);
        for (float i = h - sqrtR; i <= h + sqrtR; i += 0.1f)
        {
            float x = i;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            float y1 = Mathf.Sqrt(r - Mathf.Pow(x - h, 2)) + k;
            float y2 = -Mathf.Sqrt(r - Mathf.Pow(x - h, 2)) + k;
            cube.transform.position = new Vector3(x, y1, 0);
            cube2.transform.position = new Vector3(x, y2, 0);
        }
       // float r = ((x - h) * (x - h)) + ((y - k) * (y - k)) + k;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
