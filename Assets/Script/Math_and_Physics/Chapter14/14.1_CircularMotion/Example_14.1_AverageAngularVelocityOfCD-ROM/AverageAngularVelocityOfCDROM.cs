using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageAngularVelocityOfCDROM : MonoBehaviour
{
    public float rpm;
    public float rpmRad;
    public float radius;
    public float t;
    public float w;
    public float initialDisplacement;
    public float endDisplacement;
    public float arcStart;
    public float arcEnd;

    // Start is called before the first frame update
    void Start()
    {
      //  initialDisplacement = arcStart / radius;
      //  endDisplacement = arcEnd / radius;
      //  w = (endDisplacement - initialDisplacement) / t;

        rpmRad = rpm * radius;
        w =  rpmRad / t;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
