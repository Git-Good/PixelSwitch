using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class PostScore : MonoBehaviour {
	// THIS IS FOR SHARING YOUR SCORE. MAKE IT OPTIONAL TO SHARE
	
	private int HScore;

	public void SendScore() {
		HScore = PlayerPrefs.GetInt ("HighScore");
		if (PlayGamesPlatform.Instance.localUser.authenticated) {
			PlayGamesPlatform.Instance.ReportScore (HScore, "CgkIjb_-z4oaEAIQBg", (bool success) => {
				PlayGamesPlatform.Instance.ShowLeaderboardUI ("CgkIjb_-z4oaEAIQBg");
			});
		} else {
			PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder ().Build ();
			GooglePlayGames.PlayGamesPlatform.InitializeInstance (config);
			//GooglePlayGames.PlayGamesPlatform.DebugLogEnabled = true;
			GooglePlayGames.PlayGamesPlatform.Activate ();
			PlayGamesPlatform.Instance.localUser.Authenticate((bool success) => {
				PlayGamesPlatform.Instance.ReportScore (HScore, "CgkIjb_-z4oaEAIQBg", (bool success2) => {
					PlayGamesPlatform.Instance.ShowLeaderboardUI ("CgkIjb_-z4oaEAIQBg");
				});
			});
		}
	}
}
