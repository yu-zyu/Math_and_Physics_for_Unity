using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImputationMethod : MonoBehaviour
{
    public DefaultStraight straight1;
    public DefaultStraight straight2;

    // Start is called before the first frame update
    void Start()
    {
        float a = -1 * straight1.a;
        float right = straight2.c - (straight2.b * straight1.c);
        float left =  straight2.a + (straight2.b *  a);

        float x = right / left;
        
        float y = straight1.c - (straight1.a * x);

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, 0);
        Debug.Log(left);
        Debug.Log(right);
        Debug.Log(cube.transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
