using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegativeAngle : MonoBehaviour
{
    public Dictionary<int, float> angleList = new Dictionary<int, float>();
    public int angle;
    public float sin;
    public float minus_sin;
    // Start is called before the first frame up.PI/6date
    void Start()
    {
        angle = 30;
        angleList.Add(30, Mathf.PI / 6);
        angleList.Add(-30, -Mathf.PI / 6);
        angleList.Add(45, Mathf.PI / 4);
        angleList.Add(-45, -Mathf.PI / 4);
        angleList.Add(60, Mathf.PI / 3);
        angleList.Add(-60, -Mathf.PI / 3);
        angleList.Add(90, Mathf.PI / 2);
        angleList.Add(-90, -Mathf.PI / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (angleList.ContainsKey(angle))
        {
            sin = Mathf.Sin(angleList[angle]);
            minus_sin = -Mathf.Sin(angleList[angle]);
        }
        else
        {
            sin = 0;
            minus_sin = 0;
        }
    }
}
