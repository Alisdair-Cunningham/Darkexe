using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour {
	public GameObject player;
	private Vector3 _offset;

	Quaternion lastFrameLookR;
	Quaternion thisFrameLookR;

	Rigidbody playerRB;

	void Start(){
		playerRB = player.GetComponent<Rigidbody> ();
		_offset = transform.position - player.transform.position;
	}

	void Update(){
		if (playerRB.velocity.sqrMagnitude > 0.0f) {
			Quaternion thisFrameLookR = Quaternion.LookRotation (playerRB.velocity);
			Quaternion realLookR = Quaternion.Slerp (lastFrameLookR, thisFrameLookR, 0.03f);

			lastFrameLookR = realLookR;

			Vector3 rotatedOffset = realLookR * _offset;
			transform.position = player.transform.position + rotatedOffset;
			transform.LookAt (player.transform.position);
		}
	}
}