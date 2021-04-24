using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleBetweenTwoVectors : MonoBehaviour
{
    public Vector3 C;
    public Vector3 D;
    public GameObject playerC;
    public GameObject playerD;
    public GameObject player;
    public bool isC;
    public LineRenderer lineRenderer;
    public float t; 
    public GameObject changeV;


    // Start is called before the first frame update
    void Start()
    {
        float c = Mathf.Sqrt(Mathf.Pow(C.x, 2) + Mathf.Pow(C.y, 2) + Mathf.Pow(C.z, 2));
        Debug.Log("c "+c);
        float d = Mathf.Sqrt(Mathf.Pow(D.x, 2) + Mathf.Pow(D.y, 2) + Mathf.Pow(D.z, 2));
        Debug.Log("d " + d);
        float cd = (C.x * D.x) + (C.y * D.y) + (C.z * D.z);
        Debug.Log("cd " + cd);
        float cos = cd / (c * d);
        Debug.Log("cos " + cos);
        float Acos = Mathf.Acos(cos);
        Debug.Log("Acos " + Acos);
        float deg = Acos * Mathf.Rad2Deg;
        Debug.Log("deg " + deg);

        playerC.transform.position = C;
        playerD.transform.position = D;
        player.transform.LookAt(C);
        Debug.Log("C " + player.transform.localRotation);

        float vecto = Vector3.Angle(C, D);
        Debug.Log(" " + vecto  );

        //        C.Normalize();
        //        D.Normalize();
        //        float cosa = Vector3.Dot(C, D);
        //        float rad = Mathf.Acos(cosa);
        //        Debug.Log("rad " + rad);

        lineRenderer.SetPosition(0, player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

        if (isC)
        {
            if (changeV != playerC )
            {
                changeV = playerC;
                player.transform.position = new Vector3(0, 0, 0);
                player.transform.LookAt(changeV.transform);
            }
            lineRenderer.SetPosition(1, playerC.transform.position);
        }
        else
        {
            if (changeV != playerD)
            {
                changeV = playerD;
                player.transform.position = new Vector3(0, 0, 0);
                player.transform.LookAt(changeV.transform);
            }
            lineRenderer.SetPosition(1, playerD.transform.position);
        }

        t += Time.deltaTime;
        if (0.1f <= t)
        {
            player.transform.Translate(Vector3.forward * 1);
            t = 0;
        }

        if(C.z >= player.transform.position.z)
        {
            player.transform.position = new Vector3(0, 0, 0);
        }

        if(D.z >= player.transform.position.z)
        {
            player.transform.position = new Vector3(0, 0, 0);
        }
    }
}
