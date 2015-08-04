using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	public GameObject UI;

	// Use this for initialization
	void Start () {
		UI.SetActive (false);
		GetComponent<SpriteRenderer>().enabled = true;
		Time.timeScale = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0 && Input.GetMouseButtonDown (0)) {
			Time.timeScale = 1;
			UI.SetActive(true);
			GetComponent<SpriteRenderer>().enabled = false;
		}
	
	}
}
