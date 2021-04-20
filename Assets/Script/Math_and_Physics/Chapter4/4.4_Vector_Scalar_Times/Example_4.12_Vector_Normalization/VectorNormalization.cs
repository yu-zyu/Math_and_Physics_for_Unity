using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorNormalization : MonoBehaviour
{
    public Vector3 a;
    public float size;
    public Vector3 result;

    // Start is called before the first frame update
    void Start()
    {
        size = Mathf.Sqrt(Mathf.Pow(a.x, 2) + Mathf.Pow(a.y, 2) + Mathf.Pow(a.z, 2));
        result = new Vector3(a.x / size, a.y / size, a.z / size);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
