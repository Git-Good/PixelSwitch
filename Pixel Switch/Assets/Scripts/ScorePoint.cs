using UnityEngine;
using System.Collections;

public class ScorePoint : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			Score.AddPoint();
			gameObject.SetActive(false);
			WallSpawner ws = GameObject.Find("WallSpawner").GetComponent<WallSpawner>();
			ws.SpawnNewWall();
		}
	}

}
