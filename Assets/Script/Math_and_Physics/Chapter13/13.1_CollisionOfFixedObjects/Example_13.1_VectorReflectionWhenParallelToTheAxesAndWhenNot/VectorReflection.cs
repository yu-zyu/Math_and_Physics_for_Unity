using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorReflection : MonoBehaviour
{
    public Vector2 col;
    public Vector2 colReflect;
    // Start is called before the first frame update
    void Start()
    {
        colReflect = new Vector2(-col.x, col.y);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
