using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3D : MonoBehaviour
{
    public Vector3 p1;
    public Vector3 p2;
    public Vector3 straightLine;
    // Start is called before the first frame update
    void Start()
    {
        p1 = gameObject.transform.position;
        straightLine.x = p2.x - p1.x;
        straightLine.y = p2.y - p1.y;
        straightLine.z = p2.z - p1.z;
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = straightLine;
    }
}
