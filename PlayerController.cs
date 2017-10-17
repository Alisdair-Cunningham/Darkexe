using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody rb;
	public int Speed;
	public bool InAir;
	public int Up;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		bool Jump = Input.GetKey (KeyCode.Space);
		if (Jump && !InAir) {
			for (var i = 0; i <= 0.1; i++) {
				Up = 500;
				InAir = true;
			}
		} else {
			for (var i = 0; i <= 10; i++) {
				Up = 0;
			}
		}
		Vector3 movement = new Vector3 (moveHorizontal * 2, Up, moveVertical * 2);
		rb.AddForce (movement * Speed);
	}
	void OnCollisionEnter(Collision other){
		if(other.collider.CompareTag("Ground")){
			InAir = false;
			Up = 0;
		}
	}
}
