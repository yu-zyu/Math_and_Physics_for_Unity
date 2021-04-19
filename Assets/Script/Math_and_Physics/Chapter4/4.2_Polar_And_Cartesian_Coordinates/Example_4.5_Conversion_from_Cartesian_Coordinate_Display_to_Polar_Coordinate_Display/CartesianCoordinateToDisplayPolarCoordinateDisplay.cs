using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartesianCoordinateToDisplayPolarCoordinateDisplay : MonoBehaviour
{

    public float x;
    public float y;
    public float mag;
    public float dir;

    public Math_and_PhysicsLib.Vector2D_polar vec = new Math_and_PhysicsLib.Vector2D_polar();
    public Math_and_PhysicsLib.Vector2D_comp comp = new Math_and_PhysicsLib.Vector2D_comp();
    // Start is called before the first frame update
    void Start()
    {
        comp.x = x;
        comp.y = y;
        Math_and_PhysicsLib.CompToPolarConversion(comp, ref vec);
        mag = vec.mag;
        dir = vec.dir;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
