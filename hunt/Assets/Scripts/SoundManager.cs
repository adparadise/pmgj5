using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip music;
	
	public static SoundManager instance;
	private AudioSource[] audioSource;

	// Use this for initialization
//	void Start () {
//		instance = this;
//		audioSource = GetComponents<AudioSource> ();
//		wasPlaying = new bool[audioSource.Length];
//		//Start the day music at start of game
//		audioSource[0].clip = dayMusic;
//		audioSource[1].clip = nightMusic;
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (GameManager.instance.timeUntilDark < 5.0f && !fadingToDark) {
//			StartFadeToDark();
//			Debug.Log ("Starting Fade to Dark");
//		}
//	}
//	
//	public void pause() {
//		for (int i = 0; i < this.audioSource.Length; ++i) {
//			AudioSource source = this.audioSource[i];
//			this.wasPlaying[i] = source.isPlaying;
//			if (source.isPlaying) source.Pause();
//		}
//	}
//	
//	public void unpause() {
//		for (int i = 0; i < this.audioSource.Length; ++i) {
//			AudioSource source = this.audioSource[i];
//			if (this.wasPlaying[i]) source.Play();
//		}
//	}
//	
//	public void beginRound() {
//		this.endRound();
//		audioSource[0].Play();
//	}
//	
//	public void endRound() {
//		this.StopAllCoroutines();
//		this.fadingToDark = false;
//		audioSource[0].Stop();
//		audioSource[0].volume = 1.0f;
//		audioSource[1].Stop();
//	}
}



