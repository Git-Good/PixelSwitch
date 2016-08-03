using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public static Score Instance;
	public static int score { get; set; }

	//static int score = 0;
	private int highScore;
    private bool played = false;
    Text scoreText, highScoreText;

    AudioSource scoreS;

    void Awake()
    {
        Instance = this;
        scoreS = GetComponent<AudioSource>();
    }

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        score = 0;
        //Debug.Log("High Score: " + PlayerPrefs.GetInt ("HighScore"));
        scoreText = gameObject.GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "" + score;
        scoreS.Play();
        if (score > highScore)
        {
            scoreText.color = new Color32(238, 232, 170, 255);
            scoreText.fontSize = 60;
            if (played == false)
            {
                played = true;
            }
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        if (score > 5)
        {
            Time.timeScale += 1.2f * Time.deltaTime;
        }
    }

    public void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
    }
}
