using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToFindNewPositionWhenTheSpeedIsConstant : MonoBehaviour
{

    public float D;
    public float v;
    public float t;
    public float targetPos;

    // Start is called before the first frame update
    void Start()
    {
        D = targetPos + v * t;
        gameObject.transform.position += new Vector3(D,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
