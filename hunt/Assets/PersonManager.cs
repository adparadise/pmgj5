using UnityEngine;
using System.Collections;

public class PersonManager : MonoBehaviour {
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
		if (rigidbody2D.position == goalLocation) {
			findNewGoal();
		}

//		Vector2 normalizedVector = (new Vector2 (goalLocation.x, goalLocation.y)).normalized;
		Vector2 normalizedVector = Vector2.MoveTowards (rigidbody2D.position, goalLocation, speed);
		Debug.Log (normalizedVector);
		rigidbody2D.MovePosition ( normalizedVector );


		/// = Vector3.MoveTowards (this.transform.position, goalLocation, speed);
//		this.transform.Translate(Vector3.MoveTowards (this.transform.position, goalLocation, speed) );
//		this.transform.position = (Vector3.MoveTowards (this.transform.position, goalLocation, speed) );
	}

	public void OnCollisionEnter(Collision collision) {
		Debug.Log ("DERP");
		if (collision.gameObject.tag == "Key") {

		}

	}

	private void findNewGoal () {
		this.goalLocation = GameManager.findRandomPointOnMap ();
	}

}
