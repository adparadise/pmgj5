using UnityEngine;
using System.Collections;

public class PersonManager : MonoBehaviour {
	public float speed;
	public Vector3 currentLocation;
	public Vector3 goalLocation;

	// Use this for initialization
	void Start () {
		findNewGoal ();

	}
	
	// Update is called once per frame
	void Update () {
		// Do animation updates here.
	}

	void FixedUpdate () {
		if (currentLocation == goalLocation) {
			findNewGoal();
		}

		currentLocation = Vector3.MoveTowards (currentLocation, goalLocation, speed);
		this.transform.position = currentLocation;
	}

	private void findNewGoal () {
		this.goalLocation = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);
//		Vector3 newGoalLocation =
	}





}
