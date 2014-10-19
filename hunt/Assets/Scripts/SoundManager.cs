using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip music;
	public AudioClip chaseMusic;
	
	public static SoundManager instance;
	public AudioSource audioSource;

	private bool[] wasPlaying;
	private int counterForNextClip;

	// Use this for initialization
	void Start () {
		Debug.Log ("Creating Sound Manager");
		
		if (instance == null) {
			instance = this;
		} else {
			Debug.LogError("Only one copy of gamemanager allowed!");
		}


	}
	
	// Update is called once per frame
	void Update () {
		if (this.audioSource.isPlaying) {
			// do nothing
		} else {
			this.counterForNextClip++;
			if (this.counterForNextClip == 2) {
				// play second track
				this.audioSource.clip = this.chaseMusic;
				this.audioSource.Play ();
			} else if (this.counterForNextClip == 1) {
				this.audioSource.Play ();
			}

			// Do nothing if no more sound is available.

		}
	}
	
	public void pause() {
	}
	
	public void unpause() {

	}
	
	public void beginRound() {
		this.audioSource.Stop ();
		this.counterForNextClip = 0;
		this.audioSource.clip = music;
		this.audioSource.Play ();

	}
	
	public void endRound() {
	}
}



