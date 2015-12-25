using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class Leaderboard : MonoBehaviour {

	public void ShowBoard() {
		PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder ()
			.Build ();
		GooglePlayGames.PlayGamesPlatform.InitializeInstance (config);
		GooglePlayGames.PlayGamesPlatform.DebugLogEnabled = true;
		GooglePlayGames.PlayGamesPlatform.Activate ();
		PlayGamesPlatform.Instance.localUser.Authenticate((bool success) => {});
	}
}
