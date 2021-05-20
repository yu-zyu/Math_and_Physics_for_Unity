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
	public Vector3 gravityScale;
	public float g;

    public const float dt = 1f / 60f;    //微小時間dtに相当する部分
    public float t;
    public float vo;
	public void AddForce(Vector3 force) {
		acceleration += force;	//加速度を増やすには、力を加えれば良い！
	}
	
	void FixedUpdate () {

		if (Input.GetKeyDown(KeyCode.Space))
		{
			t = 0;
			vo = 5;
        }

        acceleration += acce.y * mass * gravityScale;
        velocity += acceleration * t;
        
        position.y = 0.5f * (g * Mathf.Pow(t, 2)) + (vo * t);
        //こっちでもいい vからyを求める
        //position.y +=  ((-9.8f * t + vo) * dt);  //速度を時間積分
        t += dt;

        topTime = vo / gravityScale.y;

        if(topTime <= transform.position.y)
        {

               // StartCoroutine(WaitBreak(topTime));

        }

        transform.position = position;

        if (transform.position.y < 0)
        {
            transform.position = new Vector3(0, 0, 0);
            //    StartCoroutine(WaitBreak(topTime));
        }
        acceleration = Vector3.zero;

        //Debug.Log(topTime.ToString("F2") + "秒後に最高点("+ gameObject.transform.position.y +")に達します");
    }

    private IEnumerator WaitBreak(float _waitTime)
	{
		yield return new WaitForSeconds(0);
		Debug.Break();
	}
}