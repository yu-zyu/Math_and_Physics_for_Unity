using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCenterAndRadius : MonoBehaviour
{
    public Transform player;
    public Transform playerCircle;
    public float h;
    public float k;
    public float l;
    public float r;
    public LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //距離の公式を使って半径を求める
        r = Mathf.Pow(playerCircle.position.x - player.position.x, 2) + Mathf.Pow(playerCircle.position.y - player.position.y, 2) + Mathf.Pow(playerCircle.position.z - player.position.z, 2);

        lineRenderer.SetPosition(0, player.position);
        lineRenderer.SetPosition(1, playerCircle.position);

        h = player.position.x;
        k = player.position.y;
        l = player.position.z;

        float sqrtR = Mathf.Sqrt(r);
        for (float i = h-k - sqrtR; i <= h + k + sqrtR; i++)
        {
            for (float j = h -k- sqrtR; j <= h + k + sqrtR; j++)
            {

                float x = i;
                float y = j;
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                float z1 = Mathf.Sqrt(r - Mathf.Pow(x - h, 2) - Mathf.Pow(y - k, 2))  + l;
                float z2 = -Mathf.Sqrt(r - Mathf.Pow(x - h, 2) - Mathf.Pow(y - k, 2)) + l;
                cube.transform.position = new Vector3(x, y, z1);
                cube2.transform.position = new Vector3(x, y, z2);

            }
        }
        // float r = ((x - h) * (x - h)) + ((y - k) * (y - k)) + k;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
