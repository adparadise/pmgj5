using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	public static UIManager instance;

	// UI Elements
	public UITimer timer;

	// Use this for initialization
	void Start () {
		Debug.Log ("Creating UI Manager");

		if (instance == null) {
			instance = this;
		} else {
			Debug.LogError("Only one copy of gamemanager allowed!");
		}

		timer.startTimer();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
