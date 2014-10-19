using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip music;
	
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

		this.counterForNextClip = 0;

//		this.audioSource = new AudioSource ();
//		this.audioSource = GameObject.AddComponent<AudioSource> ();
		this.audioSource.clip = music;
		this.audioSource.loop = true;

		this.audioSource.Play ();
//		audioSource = GetComponents<AudioSource> ();
//		wasPlaying = new bool[audioSource.Length];
//		audioSource[0].clip = music;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.audioSource.isPlaying) {
			// do nothing
		} else {
			this.counterForNextClip++;
			if (this.counterForNextClip > 1) {
				// play second track
			}

			this.audioSource.Play ();
		}
	}
	
	public void pause() {
//		for (int i = 0; i < this.audioSource.Length; ++i) {
//			AudioSource source = this.audioSource[i];
//			this.wasPlaying[i] = source.isPlaying;
//			if (source.isPlaying) source.Pause();
//		}
	}
	
	public void unpause() {
//		for (int i = 0; i < this.audioSource.Length; ++i) {
//			AudioSource source = this.audioSource[i];
//			if (this.wasPlaying[i]) source.Play();
//		}
	}
	
	public void beginRound() {
//		this.endRound();
//		audioSource[0].Play();

	}
	
	public void endRound() {
//		audioSource[0].Stop();
//		audioSource[0].volume = 1.0f;
	}
}



