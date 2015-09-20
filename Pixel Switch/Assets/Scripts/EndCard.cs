using UnityEngine;
using System.Collections;

public class EndCard : MonoBehaviour {

	public GameObject UI;
	public GameObject StartUI;
	public GameObject ScoreUnits;
	public GameObject ScoreTens;
	public GameObject ScoreHundreds;
	public GameObject HScoreU;
	public GameObject TScoreU;

	bool showEndCard = false;
	
	// Use this for initialization
	void Start () {
		StartUI.SetActive (false);
		UI.SetActive (false);
		//Time.timeScale = 0;
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
		}
	}

	public void Tapped () {
		Application.LoadLevel ("PixelSwitch");
	}

	public void CharSel() {
		Application.LoadLevel ("Character Select");
	}
}
