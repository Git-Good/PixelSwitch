using UnityEngine;
using System.Collections;

public class WallSpawner : MonoBehaviour {
	
	public GameObject[] wallList;

	// Use this for initialization
	void Start() {
		SpawnNewWall ();
	}
	
	public void SpawnNewWall(){
		int i = Random.Range (0, wallList.Length);
		Instantiate (wallList [i], transform.position, Quaternion.identity);
	}
}
