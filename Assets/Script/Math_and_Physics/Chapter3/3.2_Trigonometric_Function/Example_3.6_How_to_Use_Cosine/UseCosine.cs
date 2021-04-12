using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCosine : MonoBehaviour
{
    public float hyp;
    public Distance_Between_Two_Points target;
    public TrigonometricTable trigonometricTable;
    public float a;
    public int rad;
    // Start is called before the first frame update
    void Start()
    {
     }

    // Update is called once per frame
    void Update()
    {
       hyp = target.distance;
        rad = Mathf.FloorToInt(gameObject.transform.rotation.eulerAngles.x);

        a = hyp * trigonometricTable.cos_table[rad];
        Debug.Log("Shadow: "+ a);
    }
}
