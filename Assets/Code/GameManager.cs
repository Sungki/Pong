using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject playerWon;
	public Text textString;

	public GameObject num0;
	public GameObject num1;
	public GameObject num2;
	public GameObject num3;
	public GameObject num4;
	public GameObject num5;
	public GameObject num6;
	public GameObject num7;
	public GameObject num8;
	public GameObject num9;


	List<GameObject> numberList;


	public GameObject player1;
	public GameObject player2;
	public GameObject ballprefab;

	GameObject player1score;
	GameObject player2score;

	public int player1count=0;
	public int player2count=0;

	public bool startFlag = false;
	bool EndFlag = false;


	void Start () {
		playerWon.SetActive (false);
		numberList = new List<GameObject> ();

		numberList.Add (num0);
		numberList.Add (num1);
		numberList.Add (num2);
		numberList.Add (num3);
		numberList.Add (num4);
		numberList.Add (num5);
		numberList.Add (num6);
		numberList.Add (num7);
		numberList.Add (num8);
		numberList.Add (num9);
			
		player1score = Instantiate (num0,player1.transform.position+Vector3.up*1f,Quaternion.Euler(90,0,0));
		player2score = Instantiate (num0,player2.transform.position+Vector3.up*1f,Quaternion.Euler(90,0,0));
	}

	void Update () {
		player1score.transform.position = player1.transform.position + Vector3.up * 1f;
		player2score.transform.position = player2.transform.position + Vector3.up * 1f;

		if (!startFlag) {
			player1.transform.position = new Vector3 (-5f, 0.5f, 0f);
			player2.transform.position = new Vector3 (5f, 0.5f, 0f);
			showNum ();
			if (!EndFlag) {
				float direction = Random.Range (-175f, 175f);
				var ball = (GameObject)Instantiate (ballprefab, new Vector3 (0f, 0.2f, 0f), Quaternion.Euler (0f, direction, 0f));
				ball.GetComponent<Rigidbody>().velocity = ball.transform.forward * 5f;
				startFlag = true;
			}
		} else {
		}
	}

	void showNum()
	{
		Destroy (player1score.gameObject);
		Destroy (player2score.gameObject);

		if (player1count > 9) {
			player1count = 9;
			EndFlag = true;
			textString.text = "Player 1 Won!!";
			playerWon.SetActive (true);
			print ("Player 1 Won!!!!!");
		}

		if (player2count > 9) {
			player2count = 9;
			EndFlag = true;
			textString.text = "Player 2 Won!!";
			playerWon.SetActive (true);
			print ("Player 2 Won!!!!!");
		}
		
		player1score = Instantiate (numberList[player1count],player1.transform.position+Vector3.up*1f,Quaternion.Euler(90,0,0));
		player2score = Instantiate (numberList[player2count],player2.transform.position+Vector3.up*1f,Quaternion.Euler(90,0,0));
	}
}
