using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour {
	public Light player;
	public Color Blue = Color.blue;
	public Color Green = Color.green;
	public int Colornum;
	// Use this for initialization
	void Start () {
		player = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		player.color = Color.Lerp (Blue, Green, Colornum);
	}
}
