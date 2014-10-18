using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	// Modifiable information
	public float widthOfLevel;
	public float heightOfLevel;
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
			GameObject person = (GameObject)Instantiate(personPrefab);
			this.peopleRefs.Add(person);
			person.rigidbody2D.position = findRandomPointOnMap();
		}
	}

	private void spawnPlayer() {
		Debug.Log("Spawning player!");

		this.player = (GameObject)Instantiate(playerPrefab);
		this.player.transform.position = new Vector2(0,0);

	}


	public static Vector2 findRandomPointOnMap() {
		return new Vector2(Random.Range(-GameManager.instance.widthOfLevel, GameManager.instance.widthOfLevel),
		                   Random.Range(-GameManager.instance.heightOfLevel, GameManager.instance.heightOfLevel));
	}
}


