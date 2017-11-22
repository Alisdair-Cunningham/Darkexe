using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {
	public string sceneToLoad;
	// Use this for initialization
	void OnCollision (Collision player) {
		SceneManager.LoadScene (sceneToLoad);
	}
}
