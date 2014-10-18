using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	// Modifiable information
	public int numberOfPeople;

	public List<GameObject> peopleRefs;
	public GameObject player;


	// Prefabs.
	public GameObject playerPrefab;
	public GameObject personPrefab;

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
		this.spawnPlayer();
		this.spawnPeople ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	private void spawnPeople() {
		Debug.Log ("Spawning " + this.numberOfPeople + " people.");
		for (int i = 0; i < this.numberOfPeople; ++i) {
			GameObject player = (GameObject)Instantiate(personPrefab);
			this.peopleRefs.Add(player);
			player.transform.position = new Vector3(0,0,0);
		}
	}

	private void spawnPlayer() {
		Debug.Log("Spawning player!");

		this.player = (GameObject)Instantiate(playerPrefab);
		player.transform.position = new Vector3(0,0,0);

	}

}
	
	
	