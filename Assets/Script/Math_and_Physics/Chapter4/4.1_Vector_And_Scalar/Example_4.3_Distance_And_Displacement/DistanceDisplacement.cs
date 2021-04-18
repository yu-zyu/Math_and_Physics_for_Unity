using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDisplacement : MonoBehaviour
{
    public Transform player;
    public float start;
    public float distance;
    public float displacement;

    // Start is called before the first frame update
    void Start()
    {
        start = player.position.x;
        StartCoroutine(Move(2.0f, 250));
        StartCoroutine(Move(4.0f, 100));
        StartCoroutine(Move(6.0f, 450));

        displacement = start - player.position.y;
    }


    IEnumerator Move(float delay, float distanceNum )
    {
        //delay秒待つ
        yield return new WaitForSeconds(delay);
        distance += Mathf.Abs(player.position.x - distanceNum);
        player.position = new Vector3(distanceNum, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {


    }
}
