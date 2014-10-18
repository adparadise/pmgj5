using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	private Vector2 speed = new Vector3(1, 0, 0);
	void FixedUpdate() {
		Vector2 next = rigidbody2D.position + speed * Time.deltaTime;
		rigidbody2D.MovePosition(next);	
	}
}
