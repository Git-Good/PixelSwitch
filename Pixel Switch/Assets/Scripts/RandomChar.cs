using UnityEngine;
using System.Collections;

public class RandomChar : MonoBehaviour {

	public GameObject[] playerList;
	
	// Use this for initialization
	void Start() {
		SpawnRandomChar ();
	}
	
	public void SpawnRandomChar(){
		int i = Random.Range (0, playerList.Length);
		Instantiate (playerList [i], transform.position, Quaternion.identity);
	}
}
