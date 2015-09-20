using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public static Score Instance;
	public static int score { get; set; }

	int previousScore = -1;
	public Sprite[] numberSprites;
	public SpriteRenderer Units, Tens, Hundreds, ScoreU, ScoreT, ScoreH, HSU, HST, HSH;
	public GameObject NewImage;

	bool newScore = false;

	//static int score = 0;
	static int highScore; 

	void Awake() {
		Instance = this;
	}

	void Start (){
		score = 0;
		PlayerPrefs.DeleteAll ();
		(Tens.gameObject as GameObject).SetActive(false);
		(Hundreds.gameObject as GameObject).SetActive(false);
		highScore = PlayerPrefs.GetInt ("HighScore");
	}

	void Update () {
		if (previousScore != score) { //save perf from non needed calculations 
			if (score < 10) {
				//just draw units
				Units.sprite = numberSprites [score];
			} else if (score >= 10 && score < 100) {
				(Tens.gameObject as GameObject).SetActive (true);
				Tens.sprite = numberSprites [score / 10];
				Units.sprite = numberSprites [score % 10];
			} else if (score >= 100) {
				(Tens.gameObject as GameObject).SetActive (true);
				(Hundreds.gameObject as GameObject).SetActive (true);
				Hundreds.sprite = numberSprites [score / 100];
				int rest = score % 100;
				Tens.sprite = numberSprites [rest / 10];
				Units.sprite = numberSprites [rest % 10];
			}
		}
	}

	static public void AddPoint() {
		score++;
		if (score > highScore) {
			highScore = score;
			PlayerPrefs.SetInt("HighScore", highScore);
			Score.Instance.newScore = true;
		}
		if (score > 5) {
			Time.timeScale += 3f * Time.deltaTime;
		}
		if (score > 25) {
			Time.timeScale += 5f * Time.deltaTime;
		}
	}
	
	public void ShowNEW() {
		if (Score.Instance.newScore) {
			NewImage.SetActive(true);
		}
	}

	public void ShowHighScore () {
		if (highScore < 10) {
			//just draw units
			HSU.sprite = numberSprites [highScore];
		} else if (highScore >= 10 && highScore < 100) {
			(HST.gameObject as GameObject).SetActive (true);
			HST.sprite = numberSprites [highScore / 10];
			HSU.sprite = numberSprites [highScore % 10];
		} else if (highScore >= 100) {
			(HST.gameObject as GameObject).SetActive (true);
			(HSH.gameObject as GameObject).SetActive (true);
			HSH.sprite = numberSprites [highScore / 100];
			int rest = highScore % 100;
			HST.sprite = numberSprites [rest / 10];
			HSU.sprite = numberSprites [rest % 10];
		}
	}

	public void ShowTempScore () {
		if (score < 10) {
			//just draw units
			ScoreU.sprite = numberSprites [score];
		} else if (score >= 10 && score < 100) {
			(ScoreT.gameObject as GameObject).SetActive (true);
			ScoreT.sprite = numberSprites [score / 10];
			ScoreU.sprite = numberSprites [score % 10];
		} else if (score >= 100) {
			(ScoreT.gameObject as GameObject).SetActive (true);
			(ScoreH.gameObject as GameObject).SetActive (true);
			ScoreH.sprite = numberSprites [score / 100];
			int rest = score % 100;
			ScoreT.sprite = numberSprites [rest / 10];
			ScoreU.sprite = numberSprites [rest % 10];
		}
	}

	public void OnDestroy(){
		PlayerPrefs.SetInt ("HighScore", highScore);
	}
}
