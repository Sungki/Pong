﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	Rigidbody rb;
	Vector3 oldVel;
	Transform direction;
	float random_dir;
	 

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update () {
		this.transform.position = this.transform.position + this.transform.forward * Time.deltaTime;

		oldVel = rb.velocity;
	}

	void OnCollisionEnter(Collision c)
	{
		ContactPoint cp = c.contacts [0];
		rb.velocity = Vector3.Reflect (oldVel, cp.normal);

		if (c.gameObject.tag == "Player1" || c.gameObject.tag == "Player2") {
			if (rb.velocity.magnitude <= 30) {
				print ("Boost!!");
				rb.AddForce (rb.velocity * 5f);
			}
		}
	}
}
