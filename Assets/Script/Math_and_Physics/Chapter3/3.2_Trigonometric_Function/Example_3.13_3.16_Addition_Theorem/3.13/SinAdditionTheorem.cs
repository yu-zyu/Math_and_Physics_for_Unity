using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinAdditionTheorem : MonoBehaviour
{

    public Dictionary<int, float> angleList = new Dictionary<int, float>();
    public int angle1;
    public int angle2;
    public float left;
    public float right;
    public float cos;
    public float sin;

    public float additionTheorem;
    public float simpleAdditionTheorem;
    public float directSin;
    public Transform targetAdditionTheorem;
    public Transform targetSimple;
    public Transform targetDirect;
    public bool isMinus;

    // Start is called before the first frame update
    void Start()
    {
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

        left = Mathf.Sin(angle1 * Mathf.Deg2Rad) * Mathf.Cos(angle2 * Mathf.Deg2Rad);
        right = Mathf.Cos(angle1 * Mathf.Deg2Rad) * Mathf.Sin(angle2 * Mathf.Deg2Rad);
        if (isMinus)
        {
            additionTheorem = left - right;
            simpleAdditionTheorem = Mathf.Sin(angle2 * Mathf.Deg2Rad);
            directSin = Mathf.Sin((angle1 - angle2) * Mathf.Deg2Rad);
        }
        else
        {
            additionTheorem = left + right;
            simpleAdditionTheorem = Mathf.Cos(angle2 * Mathf.Deg2Rad);
            directSin = Mathf.Sin((angle1 + angle2) * Mathf.Deg2Rad);
        }
        targetAdditionTheorem.position = new Vector3(additionTheorem, 0, 0);
        targetSimple.position = new Vector3(simpleAdditionTheorem, 0, 0);
        targetDirect.position = new Vector3(directSin, 0, 0);
    }
}
