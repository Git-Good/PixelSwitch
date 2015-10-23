using UnityEngine;
using System.Collections;

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
		Application.LoadLevel ("Character Select");
	}

	public void StartGame(){
		Application.LoadLevel ("PixelSwitch");
	}
}
