using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentWalls : MonoBehaviour {
	public GameObject LightObj; //Variable for keeping track of light Object.
	public int Light; //integer for checking Light color
	public int Colornumer; //integer for checking wall colour (bound to a value) 
	public GameObject Wall; //Gameobject variable for wall.
	public Color aColour;
	public int Redvalue;
	public int Greenvalue;
	public int Bluevalue;
	public Material Material;
	// Use this for initialization
	void Update () {
		Light = LightObj.GetComponent<ColourChanger>().Colornum; //bind the Colornum valua from ColourChanger script to the Light Variable.
		if (Light == Colornumer) {
			Wall.SetActive (false);
		} else {
			Wall.SetActive (true);
		}
	}
	void FixedUpdate(){
		Color aColour = new Color (Redvalue, Greenvalue, Bluevalue);
		Material.color = Color.Lerp (Color.white, aColour, 0);
	}
}