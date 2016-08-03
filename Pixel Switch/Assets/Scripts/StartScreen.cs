using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour {

	public static StartScreen Instance;

	public GameObject UI;
	public GameObject StartInfo;
    public GameObject Score;

	public bool tapped = false;

	// Use this for initialization
	void Start () {
		UI.SetActive (false);
		GetComponent<SpriteRenderer>().enabled = true;
		Time.timeScale = 1;
	}
	
	void Update () {
		if (tapped == false) {
			if (Input.GetKeyDown (KeyCode.Escape)) {
                SceneManager.LoadScene("Character Select");
			}
		}
		else {
            Score.SetActive(true);
			UI.SetActive(true);
			StartInfo.SetActive (false);
			GameController gcontrol = GameObject.FindObjectOfType<GameController>();
			gcontrol.MapButtons();
			ButtonImage bImage = GameObject.FindObjectOfType<ButtonImage>();
			bImage.ButtonImageChange();
			GetComponent<SpriteRenderer>().enabled = false;
		}
	}

	public void Tapped () {
		tapped = true;
		WallSpawner ws = GameObject.FindObjectOfType<WallSpawner>();
		ws.SpawnNewWall ();
	}
}
