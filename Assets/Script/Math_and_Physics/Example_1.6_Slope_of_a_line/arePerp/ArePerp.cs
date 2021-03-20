using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArePerp : MonoBehaviour
{
    public float slope1;
    public float slope2;
    // Start is called before the first frame update
    void Start()
    {
        bool isVertical;
        isVertical = Math_and_PhysicsLib.arePerp(slope1, slope2);
        string verticalResult = isVertical ? "垂直です": "垂直じゃないです";  
        Debug.LogFormat(verticalResult);

    }
}
