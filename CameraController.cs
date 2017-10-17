using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject player; //Connect to the GameObject that the camera will follow
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position; //establish the difference between GameObject and camera
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset; //use the offset to transform the camera as the player transforms
	}
}
