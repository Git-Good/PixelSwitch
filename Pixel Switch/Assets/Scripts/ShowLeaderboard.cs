using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class ShowLeaderboard : MonoBehaviour {

	public void Show () {
		if (PlayGamesPlatform.Instance.localUser.authenticated) {
			PlayGamesPlatform.Instance.ShowLeaderboardUI ("CgkIjb_-z4oaEAIQBg");
		} else {
			PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder ()
				.Build ();
			GooglePlayGames.PlayGamesPlatform.InitializeInstance (config);
			//GooglePlayGames.PlayGamesPlatform.DebugLogEnabled = true;
			GooglePlayGames.PlayGamesPlatform.Activate ();
			PlayGamesPlatform.Instance.localUser.Authenticate((bool success) => {
				PlayGamesPlatform.Instance.ShowLeaderboardUI ("CgkIjb_-z4oaEAIQBg");
			});
		}
	}
}
