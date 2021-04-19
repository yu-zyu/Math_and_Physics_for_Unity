using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolarCoordinateDisplayToCartesianCoordinateDisplay : MonoBehaviour
{

    public float mag;
    public float dir;
    public float x;
    public float y;

    public Math_and_PhysicsLib.Vector2D_polar vec = new Math_and_PhysicsLib.Vector2D_polar();
    public Math_and_PhysicsLib.Vector2D_comp comp = new Math_and_PhysicsLib.Vector2D_comp();
    // Start is called before the first frame update
    void Start()
    {
        vec.mag = mag;
        vec.dir = dir;
        Math_and_PhysicsLib.PolarToCompConversion(vec, ref comp);
        x = comp.x;
        y = comp.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
