using UnityEngine;
using System.Collections;

public class BGM : MonoBehaviour {

	public AudioClip BGMusic;

	AudioSource Music;

	void Awake() {
		DontDestroyOnLoad (gameObject);
		Music = GetComponent<AudioSource> ();
	}

	void Start() {
		Music.clip = BGMusic;
		Music.Play ();
	}
	             
}
