using UnityEngine;
using System.Collections;

public class SwordHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision collision){
		Debug.Log ("Hit!" + collision.collider);
		if(collision.gameObject.tag == "enemyDong"){
			Destroy (collision.gameObject);
		}
	}
}
