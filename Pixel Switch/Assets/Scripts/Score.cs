using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	static int score = 0;
	static int highScore = 0; 

	// Use this for initialization
	static public void AddPoint() {
		score++;
		if (score > highScore) {
			highScore = score;
		}
		if (score > 5) {
			Time.timeScale += 3f * Time.deltaTime;
		}

	}

	void Start(){
		highScore = PlayerPrefs.GetInt ("HighScore", 0);
	}
	
	void OnDestroy(){
		PlayerPrefs.SetInt ("HighScore", highScore);
	}
}
