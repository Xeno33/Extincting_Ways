using UnityEngine;
using System.Collections;

public class Playermovement : MonoBehaviour {

	public float movementSpeed = 5.0f;
	public float mouseSensitivty = 5.0f;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Rotate the Player

		float rotLeftRight = Input.GetAxis("Mouse X") *mouseSensitivty ;
		;

		transform.Rotate (0, rotLeftRight, 0);
		
		//Moving the player
		float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
		float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;


		Vector3 speed = new Vector3 (sideSpeed, 0, forwardSpeed);

		speed = transform.rotation * speed;

		CharacterController cc = GetComponent<CharacterController> ();

		cc.SimpleMove(speed);
	}
}
