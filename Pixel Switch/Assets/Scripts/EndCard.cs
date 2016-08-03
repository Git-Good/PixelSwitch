using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndCard : MonoBehaviour {

	public GameObject UI;
	public GameObject StartUI;
    public GameObject currScore;
    public GameObject endScore;
    public GameObject highScoreObj;
    Text endScoreText, highScoreText;

    bool showEndCard = false;

    private int EScore;
    private int highScore;

    // Use this for initialization
    void Start () {
		Time.timeScale = 1;
		StartUI.SetActive (false);
		UI.SetActive (false);
        EScore = Score.score;
        currScore.SetActive(false);
        endScore.SetActive(true);
        highScoreObj.SetActive(true);
		showEndCard = true;
        endScoreText = endScore.GetComponentInChildren<Text>();
        highScoreText = highScoreObj.GetComponentInChildren<Text>();
        highScore = PlayerPrefs.GetInt("HighScore");
    }

	void Update () {
		if (showEndCard) {
			GetComponent<Animator>().SetBool("IsDisplayed", true);
            endScoreText.text = "Score: " + EScore;
            highScoreText.text = "Best: " + highScore;
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
