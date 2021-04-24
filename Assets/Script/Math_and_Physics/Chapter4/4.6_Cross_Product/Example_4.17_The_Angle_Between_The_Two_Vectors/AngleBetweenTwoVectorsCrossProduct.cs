using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleBetweenTwoVectorsCrossProduct : MonoBehaviour
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
        
        float scale = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2) + Mathf.Pow(z, 2));
        Debug.Log(scale);
        Vector3 normalization = new Vector3(x / scale, y / scale, z / scale);
        Debug.Log(normalization);

        float scaleA = Mathf.Sqrt(Mathf.Pow(a.transform.position.x, 2) + Mathf.Pow(a.transform.position.y, 2) + Mathf.Pow(a.transform.position.z, 2));
        float scaleB = Mathf.Sqrt(Mathf.Pow(b.transform.position.x, 2) + Mathf.Pow(b.transform.position.y, 2) + Mathf.Pow(b.transform.position.z, 2));

        float sin = scale / (scaleA * scaleB);
        Debug.Log("sin " + sin);
        float Asin = Mathf.Asin(sin);
        Debug.Log("Acos " + Asin);
        float deg = Asin * Mathf.Rad2Deg;
        Debug.Log("deg " + deg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
