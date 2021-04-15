using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWave : MonoBehaviour
{
    public float a;
    public float b;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        for (float x = 0; x < 100; x += 0.1f)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale = new Vector3(0.1f ,0.1f, 0.1f);
            cube.transform.position = new Vector3(x ,b * Mathf.Sin(a * x), 0);
            cube.transform.parent = gameObject.transform;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Transform child in gameObject.transform)
        {
            float x = child.transform.position.x;
            float z = child.transform.position.z;
            child.transform.position = new Vector3(x ,b * Mathf.Sin(a * x), z);
        }


        
    }
}
