using UnityEngine;
using System.Collections;

public class Werewolf : MonoBehaviour {

	// Our speed is in between these values to create more chaos.
	public float maxSpeed;
	public float minSpeed;
	private float speed;
	
	// Our speed is in between these values to create more chaos.
	public Vector2 goalLocation;
	
	// Use this for initialization
	void Start () {
		findNewGoal ();
		speed = Random.Range (minSpeed, maxSpeed);
		
	}
	
	// Update is called once per frame
	void Update () {
		// Do animation updates here.
	}
	
	void FixedUpdate () { 
		if (rigidbody2D.position == this.goalLocation) {
			findNewGoal();
			while (Mathf.Abs(this.goalLocation.magnitude) > 2) {
				findNewGoal();
			}
		}

		// TODO: shift entire movement in one direction if they can't move in the other.
		Vector2 movementVector = Vector2.MoveTowards (rigidbody2D.position, goalLocation, speed);
		
		rigidbody2D.MovePosition ( movementVector );
		
	}
	
	public void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log ("DERP");
		
	}
	
	private void findNewGoal () {
		this.goalLocation = GameManager.findRandomPointOnMap ();
	}
}
