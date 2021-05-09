using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToFindTheAverageVelocityIn3D : MonoBehaviour
{
    public Transform targetA;
    public Transform targetB;
    public Vector3 displacement;
    public Vector3 averageSpeed;
    public float time;
    public float deltaTime;
    public bool flg = false;

    // Start is called before the first frame update
    void Start()
    {
            displacement = targetB.position - targetA.position;
            averageSpeed = displacement / time;
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += Time.deltaTime;
        if(1 <= deltaTime)
        {
            if(targetA.position == targetB.position)
            {
                flg = true;
            }

            if (!flg)
            {
                targetA.position += averageSpeed;
            }
            deltaTime = 0;
        }
    }
}
