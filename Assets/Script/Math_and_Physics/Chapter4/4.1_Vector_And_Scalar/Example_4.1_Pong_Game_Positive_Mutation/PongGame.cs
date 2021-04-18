using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongGame : MonoBehaviour
{
    public Transform paddle;
    public float start;
    public float displacement;

    // Start is called before the first frame update
    void Start()
    {
        start = paddle.position.y;

        
    }

    // Update is called once per frame
    void Update()
    {
        displacement = start - paddle.position.y;
        
    }
}
