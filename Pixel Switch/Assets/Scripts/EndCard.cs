using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using UnityEngine.SceneManagement;

public class EndCard : MonoBehaviour {

	public GameObject UI;
	public GameObject StartUI;
	public GameObject ScoreUnits;
	public GameObject ScoreTens;
	public GameObject ScoreHundreds;
	public GameObject HScoreU;
	public GameObject TScoreU;

	bool showEndCard = false;

	private int HScore;
	
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		StartUI.SetActive (false);
		UI.SetActive (false);
		showEndCard = true;
		Score.Instance.ShowHighScore();
		Score.Instance.ShowTempScore();
		Score.Instance.ShowNEW();
	}

	void Update () {
		if (showEndCard) {
			GetComponent<Animator>().SetBool("IsDisplayed", true);
			ScoreUnits.SetActive (false);
			ScoreTens.SetActive (false);
			ScoreHundreds.SetActive (false);
			HScoreU.SetActive(true);
			TScoreU.SetActive(true);

			if (Input.GetKeyDown (KeyCode.Escape)) {
				SceneManager.LoadScene("MainMenu");
			}
		}
	}

	public void Tapped () {
        SceneManager.LoadScene("PixelSwitch");
	}

	public void CharSel() {
        SceneManager.LoadScene("Character Select");
	}
}
