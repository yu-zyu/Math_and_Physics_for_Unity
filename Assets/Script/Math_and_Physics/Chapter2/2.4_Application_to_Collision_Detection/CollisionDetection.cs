using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{


    public CircleGraph player1;
    public CircleGraph player2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Sqrt(Mathf.Pow(player2.h - player1.h,2) + Mathf.Pow(player2.k - player1.k,2)) <= player1.sqrtR + player2.sqrtR)
        {
            Debug.Log("衝突しています");

        }
        
    }
}
