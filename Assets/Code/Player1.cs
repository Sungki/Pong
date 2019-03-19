using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

	float speed = 10f;
	float v = 0f;

	void Start () {
		
	}
	
	void Update () {
		v = 0;
		if (Input.GetKey("w"))
			v = 1;

		if (Input.GetKey("s"))
			v = -1;
		
		transform.position += new Vector3(0,0,v*speed*Time.deltaTime);

		if(transform.position.z <= -3.5f) 
			transform.position = new Vector3(transform.position.x, transform.position.y, -3.5f);
		
		if(transform.position.z >= 3.5f) 
			transform.position = new Vector3(transform.position.x, transform.position.y, 3.5f);
		
	}
}
