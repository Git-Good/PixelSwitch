using UnityEngine;
using System.Collections;

public class BGM : MonoBehaviour {

	public AudioClip BGMusic;

	AudioSource Music;
	public static bool created = false;

	void Awake() {
		if (!created) {
			// First instance, keep this
			created = true;
			DontDestroyOnLoad (this.gameObject);
			Music = GetComponent<AudioSource> ();
		} else {
			// Duplicate
			Destroy (this.gameObject);
		}
	}

	void Start() {
		Music.clip = BGMusic;
		Music.Play ();
	}
	             
}
