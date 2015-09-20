using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class ShowLeaderboard : MonoBehaviour {

	public void Show () {
		if (PlayGamesPlatform.Instance.localUser.authenticated) {
			PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIjb_-z4oaEAIQBg");
		}
	}
}
