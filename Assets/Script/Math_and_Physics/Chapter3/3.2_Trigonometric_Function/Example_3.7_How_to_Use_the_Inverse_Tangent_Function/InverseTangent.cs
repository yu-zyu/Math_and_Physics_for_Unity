using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InverseTangent : MonoBehaviour
{

    public Transform player;
    public Transform target;
    public float[] P1 = new float[2];
    public float[] P2 = new float[2];
    public float atan;
    public float atan2;

    // Start is called before the first frame update
    void Start()
    {

        P1[0] = player.position.x;
        P1[1] = player.position.y;
        P2[0] = target.position.x;
        P2[1] = target.position.y;
        atan = Math_and_PhysicsLib.calcAngle2D(P1, P2);

         atan2 = (float)Mathf.Atan((P2[1] - P1[1]) / (P2[0] - P1[0])) * 57.29577951f;
        if(P2[1] < P1[1] && P2[0] > P1[0])
        {
        }else if((P2[1] < P1[1] && P2[0] < P2[0]) || (P2[1] > P1[1] && P2[0] < P1[0]))
        {
            atan2 = atan2 + 180;
        }
        else
        {
        //    atan2 = atan2 + 360;
        }


        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
