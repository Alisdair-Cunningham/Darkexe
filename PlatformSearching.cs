using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class PlatformSearching : MonoBehaviour {
	public GameObject Navigator; 
	NavMeshAgent Agent;
	public Transform targetedEnemy;

	// Use this for initialization
	void Start () {
		Agent = Navigator.GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		Agent.destination = targetedEnemy.transform.position;
		Agent.isStopped.Equals (false);
	}
}