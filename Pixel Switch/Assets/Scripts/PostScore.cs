using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class PostScore : MonoBehaviour {
	// THIS IS FOR SHARING YOUR SCORE. MAKE IT OPTIONAL TO SHARE
	
	private int HScore;

	public void SendScore() {
		HScore = PlayerPrefs.GetInt ("HighScore");
		if (PlayGamesPlatform.Instance.localUser.authenticated) {
			PlayGamesPlatform.Instance.ReportScore (HScore, "CgkIjb_-z4oaEAIQBg", (bool success) => {
				PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIjb_-z4oaEAIQBg");
			});
		}
	}
}
