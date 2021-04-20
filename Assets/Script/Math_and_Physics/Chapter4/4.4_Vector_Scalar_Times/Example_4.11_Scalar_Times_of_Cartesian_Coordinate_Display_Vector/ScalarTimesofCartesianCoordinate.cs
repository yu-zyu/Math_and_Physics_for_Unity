using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalarTimesofCartesianCoordinate : MonoBehaviour
{
    public float a1;
    public float a2;
    public float a;
    public float a1_result;
    public float a2_result;
    // Start is called before the first frame update
    void Start()
    {
        a1_result = a1 * a;
        a2_result = a2 * a;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
