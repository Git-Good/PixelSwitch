using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	void Start() {
		Time.timeScale = 1;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
	}

	public void StartButton(){
        SceneManager.LoadScene("Character Select");
	}

	public void StartGame(){
        SceneManager.LoadScene("PixelSwitch");
	}
}
