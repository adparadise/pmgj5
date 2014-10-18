using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public List<GameObject> peopleRefs;
	public GameObject player;

	public void Awake() {
		this.peopleRefs = new List<GameObject>();
		
		if (instance == null) {
			instance = this;
		} else {
			Debug.LogError("Only one copy of gamemanager allowed!");
		}
		
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
	
	
	