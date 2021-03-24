using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool isMove;
    public StraightGenarater StraightGenarater;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isMove)
        {
            StartCoroutine(Move());

            isMove = false;
        }
        
    }


IEnumerator Move()
    {
        foreach (Transform childTransform in StraightGenarater.straightLine.transform)
        {
            gameObject.transform.position = childTransform.position;
            if(gameObject.transform.position == new Vector3(30, 40, 0))
            {
yield break;


            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
