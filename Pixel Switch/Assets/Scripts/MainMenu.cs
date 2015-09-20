using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void Start() {
		Time.timeScale = 1;
	}

	public void StartButton(){
		Application.LoadLevel ("Character Select");
	}

	public void StartGame(){
		Application.LoadLevel ("PixelSwitch");
	}
}
