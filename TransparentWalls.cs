using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentWalls : MonoBehaviour {
	public int BallLight;
	public GameObject Wall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		BallLight = GetComponent<ColourChanger> ().Colornum;
		Debug.Log (BallLight);
	}
}
