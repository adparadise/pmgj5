using UnityEngine;
using System.Collections;

public class PersonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		Vector2 speed = new Vector3(1, 0, 0);
		Vector2 next = rigidbody2D.position + speed * Time.deltaTime;
		rigidbody2D.MovePosition(next);	
	}
}
