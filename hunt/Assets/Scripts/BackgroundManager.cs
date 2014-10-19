using UnityEngine;
using System.Collections;

public class BackgroundManager : MonoBehaviour {

	public static BackgroundManager instance;

	public Sprite mapBackground;
	public Sprite introBackground;
	
	public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Awake () {
		Debug.Log ("Creating Background Manager");
		
		if (instance == null) {
			instance = this;
		} else {
			Debug.LogError("Only one copy of gamemanager allowed!");
		}

		
	}

	// Use this for initialization
	void Start () {
		this.showIntro();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showMap () {
		this.spriteRenderer.sprite = mapBackground;
	}

	public void showIntro () {
		this.spriteRenderer.sprite = introBackground;
	}

	public void showWin () {

	}

	public void showLose () {

	}
}
