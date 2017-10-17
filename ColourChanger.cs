using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour {
	public Light player; //Variable for keeping track of player
	public Color aColour;
	public int Redvalue;
	public int Greenvalue;
	public int Bluevalue;
	public int Colornum; //Variable for keeping track of the Color
	// Use this for initialization
	void Start () {
		player = GetComponent<Light> (); //bind the light to the player variable
	}
	void update (){
		
	}
	// Update is called once per frame
	void FixedUpdate () {
		Color aColour = new Color (Redvalue, Greenvalue, Bluevalue);
		player.color = Color.Lerp (Color.white, aColour, Colornum); //Change the color based on what Colornum is set.
	}
}
