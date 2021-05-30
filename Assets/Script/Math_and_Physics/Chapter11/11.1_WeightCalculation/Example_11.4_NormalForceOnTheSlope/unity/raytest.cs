using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raytest : MonoBehaviour
{
    public GameObject plane;
    public GameObject sphere;
    public Vector3 rag;
    public float ragf;
    public float deg;

    // Start is called before the first frame update
    void Start()
    {
        toMostUp(plane, 1, 1);
        toMostUp(sphere, 1, 1);

        //rag = plane.transform.up * sphere.transform.up;
        //ragf = ( plane.transform.up.x * sphere.transform.up.x)+ ( plane.transform.up.y * sphere.transform.up.y) + ( plane.transform.up.z * sphere.transform.up.z);
        ragf = Vector3.Dot(plane.transform.up, sphere.transform.up);
        deg = Mathf.Acos(ragf) * Mathf.Rad2Deg;
        Debug.Log(deg);
        
    }

    // Update is called once per frame
    void Update()
    {




        
    }

    public void toMostUp(GameObject obj, float y, int distance)
    {
        // レイを真上へ(Vector3.up)
        Ray ray = new Ray(obj.transform.position, obj.transform.up);
 Debug.DrawRay(ray.origin, ray.direction * 1130.0f, Color.red, 5f, false);
    }
 
}
