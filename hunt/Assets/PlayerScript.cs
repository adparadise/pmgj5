using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Vector2 goalLocation;

	// Use this for initialization
	void Start () {
	
	}

	private Vector2 speed = new Vector3(1, 0, 0);
	void FixedUpdate() {
//		Vector2 next = rigidbody2D.position + speed * Time.deltaTime;
//		rigidbody2D.MovePosition(next);	


		if (rigidbody2D.position == this.goalLocation) {
			findNewGoal();
		}
		
		Vector2 movementVector = Vector2.MoveTowards (rigidbody2D.position, this.goalLocation, 0.03f);
		
		rigidbody2D.MovePosition ( movementVector );
	}


	private void findNewGoal () {
		this.goalLocation = GameManager.findRandomPointOnMap ();
	}
}
