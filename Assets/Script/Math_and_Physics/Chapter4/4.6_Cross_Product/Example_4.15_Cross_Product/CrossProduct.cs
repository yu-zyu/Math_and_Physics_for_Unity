using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossProduct : MonoBehaviour
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
