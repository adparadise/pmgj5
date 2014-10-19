using UnityEngine;
using System.Collections;

public class WalkCycleDirection : MonoBehaviour {
	
	private Animator animator;
	private Vector2 lastPos;
	private int currentDirection = 0;
	
	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		applyAnimationFromMovement ();
	}

	void applyAnimationFromMovement () {
		Vector2 currentPos;
		
		currentPos = rigidbody2D.position;
		if (this.lastPos == null) {
			this.lastPos = currentPos;
		}
		Vector2 currentVector = new Vector2 (lastPos.x - currentPos.x, lastPos.y - currentPos.y);
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
