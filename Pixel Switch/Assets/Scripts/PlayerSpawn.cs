using UnityEngine;
using System.Collections;

public class PlayerSpawn : MonoBehaviour {

	// Use this for initialization
	void Start() {
		SpawnSelectedChar ();
	}
	
	public void SpawnSelectedChar(){
		Instantiate (Resources.Load ("Characters/" + PlayerPrefs.GetString("Player")), transform.position, Quaternion.identity);
	}
}
