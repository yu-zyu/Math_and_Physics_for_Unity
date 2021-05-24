using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRigidbody : MonoBehaviour
{
	public Vector3 acce;	
	public Vector3 acceleration;
	public Vector3 velocity;
	public Vector3 position;
	public Vector3 vec;
	private Rigidbody rigid;
    public float topTime;
    public float time;
	public float mass;
	public float g;

    public float y;
    public const float dt = 1f / 60f;    //微小時間dtに相当する部分
    public float t;
    public float vo;
    public float angle;
    private float vix;
    private float viy;
	public void AddForce(Vector3 force) {
		acceleration += force;	
	}

    private void Start()
    {
        vix = vo * Mathf.Cos(angle * Mathf.Deg2Rad);
        viy = vo * Mathf.Sin(angle * Mathf.Deg2Rad);

        Debug.Log("x " + vix);
        Debug.Log("y " + viy);

        topTime = viy / g;
        float landingPosition = vix * (topTime * 2);
        Debug.Log("top" + topTime);
        
        Debug.Log("landing time" + topTime*2);
        Debug.Log("landing position" + landingPosition);

        float fallTime = Mathf.Sqrt(-y / (g * 0.5f));
        Debug.Log("fall time" + (fallTime));
        
    }

    void FixedUpdate () {

        t += dt;

        vix = vo * Mathf.Cos(angle * Mathf.Deg2Rad);
        viy = vo * Mathf.Sin(angle * Mathf.Deg2Rad);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			t = 0;
		//	vo = 5;
        }

        //acceleration += acce.y * mass * g;
        //velocity += acceleration * t;

        position.x = vix * t;
        position.y = 0.5f * (g * Mathf.Pow(t, 2) * mass) + (viy * t) + y;

        //position.y = 0.5f * (g * Mathf.Pow(t, 2)) + (vo * t);
        //こっちでもいい vからyを求める
        //position.y +=  ((-9.8f * t + vo) * dt); 


        if(topTime <= transform.position.y)
        {
               // StartCoroutine(WaitBreak(topTime));
        }

        transform.position = position;

        if (transform.position.y < 0)
        {
            Debug.Log(transform.position);
            Debug.Log(t);
            transform.position = new Vector3(0, 1, 0);
            position = new Vector3(0, 1, 0);
            t = 0;
            StartCoroutine(WaitBreak(topTime));
        }

        acceleration = Vector3.zero;
    }

    private IEnumerator WaitBreak(float _waitTime)
	{
		yield return new WaitForSeconds(0);
		Debug.Break();
	}
}