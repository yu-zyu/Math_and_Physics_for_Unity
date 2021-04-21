using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindOutObject : MonoBehaviour
{
    public Transform camera;
    public Transform C;
    public Transform target;
    public Vector3 D;
    public float CD;
    public LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        lineRenderer.SetPosition(0, camera.position);
        lineRenderer.SetPosition(1, C.position);
        D = new Vector3(target.position.x - camera.position.x, target.position.y - camera.position.y, 0);
        CD = (C.position.x * D.x) + (C.position.y * D.y);
        if(0 < CD)
        {
            Debug.Log("物体はカメラ内にあります");
        }
        else
        {
            Debug.Log("物体はカメラ外にあります");
        }

        
        
    }
}
