using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2CPU : MonoBehaviour {

	float speed = 2f;

	bool movingDirection;


	void Start () {
		movingDirection = false;
	}
	
	void Update () {		
		if (!movingDirection) {
			transform.position += Vector3.forward * Time.deltaTime * speed;
			if (transform.position.z >= 3.5)
				movingDirection = true;
		} else {
			transform.position += Vector3.back * Time.deltaTime * speed;
			if(transform.position.z <= -3.5f) 
				movingDirection = false;
		}
	}
}
