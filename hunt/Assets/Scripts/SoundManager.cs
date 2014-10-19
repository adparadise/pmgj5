using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip music;
	
	public static SoundManager instance;
	private AudioSource[] audioSource;

	private bool[] wasPlaying;

	// Use this for initialization
	void Start () {
		instance = this;
		audioSource = GetComponents<AudioSource> ();
		wasPlaying = new bool[audioSource.Length];
		audioSource[0].clip = music;
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	public void pause() {
		for (int i = 0; i < this.audioSource.Length; ++i) {
			AudioSource source = this.audioSource[i];
			this.wasPlaying[i] = source.isPlaying;
			if (source.isPlaying) source.Pause();
		}
	}
	
	public void unpause() {
		for (int i = 0; i < this.audioSource.Length; ++i) {
			AudioSource source = this.audioSource[i];
			if (this.wasPlaying[i]) source.Play();
		}
	}
	
	public void beginRound() {
		this.endRound();
		audioSource[0].Play();
	}
	
	public void endRound() {
		audioSource[0].Stop();
		audioSource[0].volume = 1.0f;
		audioSource[1].Stop();
	}
}



