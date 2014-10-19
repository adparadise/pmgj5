using UnityEngine;
using System.Collections;

public class FistScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log (string.Format ("enter: {0}", other));
	}
	
	void OnTriggerExit2D(Collider2D other) {
		//Debug.Log (string.Format ("exit: {0}", other));
	}
}
