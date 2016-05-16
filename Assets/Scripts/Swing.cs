using UnityEngine;
using System.Collections;

public class Swing : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {		
		//This helps the swing animation to get the sword to swing
		if(Input.GetButton("Fire1"))
		{
			GetComponent<Animation>().Play ("Cube.003|Cube.003Action");
	}
		
}
}

//Reference: https://www.youtube.com/watch?v=1mu431dVvy4