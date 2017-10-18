using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour {

	public PlayerController Owner;
	public Vector3 RelativePos;
	private Quaternion playerRot;
	public float RotationSpeed;
	public float MoveTime;
	public float moveTimer;

	public Vector3 LookOffset = new Vector3(0, 1, 0);

	// Use this for initialization
	void Start () {
		RelativePos = transform.position - Owner.transform.position;
		playerRot = Owner.transform.rotation;
	}
	
	// Update is called once per frame
	void Latepdate () {
		if (Owner.InAir) {
			moveTimer = MoveTime;
		} else {
			if (moveTimer > 0.0f) {
				moveTimer -= Time.deltaTime;
			} else {
				playerRot = Quaternion.RotateTowards (playerRot, Owner.transform.rotation, RotationSpeed * Time.deltaTime);
			}
		}
		Vector3 pos = playerRot * RelativePos;
		transform.position = Owner.transform.position + pos;
		transform.LookAt (Owner.transform.position + LookOffset);
	}

	public void ApplyTurn (float turn) {
		playerRot = Quaternion.AngleAxis (turn * Time.deltaTime + playerRot.eulerAngles.y, Vector3.up);
	}
}
