using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceNormal : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;

    // Start is called before the first frame update
    void Start()
    {
        float x = (a.transform.position.y * b.transform.position.z) - (a.transform.position.z * b.transform.position.y);
        float y = (a.transform.position.z * b.transform.position.x) - (a.transform.position.x * b.transform.position.z);
        float z = (a.transform.position.x * b.transform.position.y) - (a.transform.position.y * b.transform.position.x);
        c.transform.position = new Vector3(x, y, z);

        float scale = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2) + Mathf.Pow(z, 2));
        Debug.Log(scale);
        Vector3 normalization = new Vector3(x / scale, y / scale, z / scale);
        Debug.Log(normalization);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
