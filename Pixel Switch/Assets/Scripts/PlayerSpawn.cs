using UnityEngine;
using System.Collections;

public class PlayerSpawn : MonoBehaviour {

	// Use this for initialization
	void Start() {
		SpawnSelectedChar ();
	}
	
	public void SpawnSelectedChar(){
        if (PlayerPrefs.GetString("Player") == "")
        {
            // Spawn default if player has never chosen a cat before
            PlayerPrefs.SetString("Player", "Pink");
        }
        Instantiate (Resources.Load ("Characters/" + PlayerPrefs.GetString("Player")), transform.position, Quaternion.identity);
	}
}
