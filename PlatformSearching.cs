using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlatformSearching : MonoBehaviour {
	private NavMeshAgent navAgent;
	private TargetData td;
	public GameObject navpoint;
	// Use this for initialization
	void Start () {
		td = new TargetData ();
			navAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		td.Target = navpoint;
		float distance = Vector3.Distance (transform.position, td.Target.transform.position);
	}
}
public class TargetData{
	public Vector3 position;
	public GameObject Target;
}
