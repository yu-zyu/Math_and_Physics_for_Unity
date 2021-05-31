using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtonsFirstLawOfMovementAirHockey : MonoBehaviour
{
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fnet(合力）＝０のとき、物体の運動は変化しない");
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(1 < t)
        {
            gameObject.transform.position += new Vector3(10, 5, 0);
            t = 0;
        }
        
    }
}
