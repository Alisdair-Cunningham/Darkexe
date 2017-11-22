using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour {
	public float Red;
	public float Green;
	public float Blue;
	// Use this for initialization
	void OnCollision(Collision Pickup){
		Red = Pickup.gameObject.GetComponent <PickupColour>().Red;
		Green = Pickup.gameObject.GetComponent <PickupColour>().Green;
		Blue = Pickup.gameObject.GetComponent <PickupColour>().Blue;
	}
}