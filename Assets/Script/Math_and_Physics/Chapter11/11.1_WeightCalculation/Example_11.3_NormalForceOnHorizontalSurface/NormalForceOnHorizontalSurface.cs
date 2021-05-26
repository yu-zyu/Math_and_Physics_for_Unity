using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalForceOnHorizontalSurface : MonoBehaviour
{
    public float lbs;
    public float n;
    public float n2;


    // Start is called before the first frame update
    void Start()
    {
        n = lbs / n;
        n2 = Mathf.Abs(n);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
