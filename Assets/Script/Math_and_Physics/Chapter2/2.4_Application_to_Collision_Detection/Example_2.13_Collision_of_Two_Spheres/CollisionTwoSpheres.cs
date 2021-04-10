using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTwoSpheres : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    bool isColBetweenSpheres;

        Math_and_PhysicsLib.sphere sphere1 = new Math_and_PhysicsLib.sphere();
        Math_and_PhysicsLib.sphere sphere2 = new Math_and_PhysicsLib.sphere();
    // Start is called before the first frame update
    void Start()
    {
        sphere1.center = new float[3];
        sphere1.radius = 3;
        sphere2.center = new float[3];
        sphere2.radius = 3;
    }

    // Update is called once per frame
    void Update()
    {
        sphere1.center[0] = target1.transform.position.x;
        sphere1.center[1] = target1.transform.position.y;
        sphere1.center[2] = target1.transform.position.z;

        sphere2.center[0] = target2.transform.position.x;
        sphere2.center[1] = target2.transform.position.y;
        sphere2.center[2] = target2.transform.position.z;
        isColBetweenSpheres = Math_and_PhysicsLib.ColBetweenSpheres(ref sphere1, ref sphere2);

        if (isColBetweenSpheres)
        {
            Debug.Log("衝突した");
        }
         
     
    }
}
