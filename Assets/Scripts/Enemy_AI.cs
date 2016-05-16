using UnityEngine;
using System.Collections;

public class Enemy_AI : MonoBehaviour {

	Transform tr_Player;
	float f_RotSpeed = 3.0f;
	float f_MoveSpeed =3.0f;

	// Use this for initialization
	void Start () {

		tr_Player = GameObject.FindGameObjectWithTag ("Player").transform;
	
	}
	
	// Update is called once per frame
	void Update () {

		//This makes the zombie look at the player
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation(tr_Player.position - transform.position), f_RotSpeed * Time.deltaTime);
	//Move to the player
		transform.position += transform.forward * f_MoveSpeed* Time.deltaTime;
	}
}

//Reference: https://www.youtube.com/watch?v=drTcfhULpLA
