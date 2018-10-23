using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rigid2D;
	float jumpForce = 780.0f;

	// Use this for initialization
	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D>();		
	}
	
	// Update is called once per frame
	void Update () {
		// ジャンプする
		if (Input.GetKeyDown(KeyCode.Space))
		{
			this.rigid2D.AddForce(transform.up * this.jumpForce);
		}
	}
}
