using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float maxSpeed = 0.1f;

	// Use this for initialization
	void Start () {
		
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
	}
}
