using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	//this sets up the player's health
	public int playerhealth = 100;
	//this lets the script know how much damage is taken
	int damage = 10;

	void Start() {
		print (playerhealth);
	}
	//This tells the script whenever the enemy hits, take damage points away
	void OnCollisionEnter(Collision _collision) {
		if(_collision.gameObject.tag=="enemyDong"){
			playerhealth -= damage;
			print("enemyDong Just touched Someone" + playerhealth);
		}
		}
}

//reference:https://www.youtube.com/watch?v=g_3aHOaKwZY