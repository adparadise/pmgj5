using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float maxSpeed = 0.1f;
	private Animator animator;
	private Vector2 lastPos;
	private int currentDirection = 0;

	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		lastPos = rigidbody2D.position;
	}
	
	void FixedUpdate() {
		float w = Input.GetAxis ("Horizontal");
		float h = Input.GetAxis ("Vertical");
		float distance = Mathf.Sqrt (Mathf.Pow (h, 2) + Mathf.Pow (w, 2));
		float direction = Mathf.Atan2 (h, w);
		
		distance = Mathf.Min (distance, maxSpeed);
		Vector2 movement = new Vector2 (distance * Mathf.Cos (direction),
		                                distance * Mathf.Sin (direction));
		
		Vector2 next = rigidbody2D.position + movement;
		rigidbody2D.MovePosition(next);	
		applyAnimationFromMovement (-w, -h);
	}

	
	void applyAnimationFromMovement (float w, float h) {
		Vector2 currentPos;
		
		currentPos = rigidbody2D.position;
		Vector2 currentVector;

		if (Mathf.Abs (w) > 0.1 || Mathf.Abs (h) > 0.1) {
			currentVector = new Vector2 (w, h);	
		} else {
			currentVector = new Vector2 (lastPos.x - currentPos.x, lastPos.y - currentPos.y);
		}
		this.lastPos = currentPos;
		
		float currentDistance = currentVector.magnitude;
		
		bool isMoving = false;
		if (currentDistance > 0.1) {
			isMoving = true;
		}
		
		bool isYDominant = Mathf.Abs (currentVector.y) > Mathf.Abs (currentVector.x);
		int direction;
		if (isYDominant) {
			if (currentVector.y > 0) {
				//direction = "north";
				direction = 0;
			} else {
				//direction = "south";
				direction = 2;
			}
		} else {
			if (currentVector.x > 0) {
				//direction = "east";
				direction = 1;
			} else {
				//direction = "west";
				direction = 3;
			}
		}
		
		if (isMoving) {
			this.currentDirection = direction;
		}
		
		setAnimationState (this.currentDirection, isMoving);
	}
	
	void setAnimationState (int direction, bool isMoving) {
		animator.SetInteger("Direction", direction);
		animator.SetBool ("IsMoving", isMoving);
	}
}
