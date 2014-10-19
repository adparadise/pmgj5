using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	public static UIManager instance;

	// UI Elements
	public UITimer timer;

	void Awake () {
		Debug.Log ("Creating UI Manager");
		
		if (instance == null) {
			instance = this;
		} else {
			Debug.LogError("Only one copy of gamemanager allowed!");
		}
		timer.guiText.enabled = false;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startNewLevel () {
		timer.resetTimer ();
		timer.guiText.enabled = true;
		timer.startTimer();
	}

	public void endLevel () {
		timer.stopTimer ();
		timer.guiText.enabled = false;
	}
}
