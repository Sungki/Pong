using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGoal : MonoBehaviour {

	public GameManager gm;

	void OnCollisionEnter(Collision c)
	{
		gm.player2count++;
		gm.startFlag=false;
		Destroy (c.gameObject);
	}
}
