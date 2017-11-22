using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody player;
	public bool Jumping;
	public float Speed;

	void Start(){
		player = GetComponent<Rigidbody> ();
	}
	void Update(){
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		if (Input.GetKeyDown (KeyCode.Space) && Jumping) {
			player.AddForce (Vector3.up * 300.0f);
		}
		Vector3 movement = new Vector3 (x, 0, z);
		player.AddForce (movement * Speed);
	}
	void FixedUpdate(){
		if (Input.GetAxis ("Vertical") > 0) 
		{
			var camdir = Camera.main.transform.TransformDirection (Vector3.forward *2);
			camdir.y = 0;
		} else if (Input.GetAxis ("Vertical") < 0) {
			var camdir2 = Camera.main.transform.TransformDirection (Vector3.back *2);
			camdir2.y = 0;
		} else if (Input.GetAxis ("Horizontal") < 0) {
			var camdir3 = Camera.main.transform.TransformDirection (Vector3.left *2);
			camdir3.y = 0;
		} else if (Input.GetAxis ("Horizontal") > 0) {
			var camdir4 = Camera.main.transform.TransformDirection (Vector3.right *2);
			camdir4.y = 0;
		}
	}
}
