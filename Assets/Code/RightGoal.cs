using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGoal : MonoBehaviour {
	public GameManager gm;

	void OnCollisionEnter(Collision c)
	{
		gm.player1count++;
		gm.startFlag=false;

		Destroy (c.gameObject);
	}
}
