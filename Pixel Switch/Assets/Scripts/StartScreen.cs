﻿using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	public static StartScreen Instance;

	public GameObject UI;
	public GameObject ScoreUnits;
	public GameObject ScoreTens;
	public GameObject ScoreHundreds;
	public GameObject StartInfo;

	bool tapped = false;

	// Use this for initialization
	void Start () {
		UI.SetActive (false);
		GetComponent<SpriteRenderer>().enabled = true;
		Time.timeScale = 0;
	}
	
	void Update () {
		if (Time.timeScale == 0 && tapped == true) {
			Time.timeScale = 1;
			UI.SetActive(true);
			ScoreUnits.SetActive (true);
			StartInfo.SetActive (false);
			GetComponent<SpriteRenderer>().enabled = false;
		}
	}

	public void Tapped () {
		tapped = true;
	}
}
