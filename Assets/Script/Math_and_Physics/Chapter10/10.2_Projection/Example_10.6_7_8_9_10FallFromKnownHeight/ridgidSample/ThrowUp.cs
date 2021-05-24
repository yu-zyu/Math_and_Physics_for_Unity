using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowUp : MonoBehaviour
{
	public Vector3 vec;
	private Rigidbody rigid;
    public float topTime;

    void Start()
	{
		rigid = GetComponent<Rigidbody>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rigid.velocity = vec;
			topTime = vec.y / (-Physics.gravity.y);
			StartCoroutine(WaitBreak(topTime));

			Debug.Log(topTime.ToString("F2") + "秒後に最高点("+ gameObject.transform.position.y +")に達します");
		}
	}

	private IEnumerator WaitBreak(float _waitTime)
	{
		yield return new WaitForSeconds(_waitTime);
		Debug.Break();
	}
}