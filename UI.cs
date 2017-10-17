using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {
	public float timeLeft = 120.0f;
	public float timeRemaining;
	public Text txt;

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			timeLeft = 0;
			SceneManager.LoadScene ("Test");
		}
		timeRemaining = Mathf.Round (timeLeft);
		txt.text = "Time: " + timeRemaining;
	}
}
