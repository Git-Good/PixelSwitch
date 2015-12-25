using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Selector : MonoBehaviour {
	
	public GameObject[] GOList;
	public List<Player> Players = new List<Player> ();
	private int _currentID;
	private PlayerList playerList;
	
	public Transform GOLocationSpot;
	
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		playerList = GameObject.FindGameObjectWithTag ("Player List").GetComponent<PlayerList> ();
		Players.Clear ();
		Players.Add (playerList.players[0]);
		Players.Add (playerList.players[1]);
		Players.Add (playerList.players[2]);
        Players.Add (playerList.players[3]);

        // if GOLocation spot is not declare, will use our own transform instead.
        if (GOLocationSpot== null){
			GOLocationSpot = transform;
		}
		// start by hiding all
		foreach(GameObject _go in GOList) {
			// we move it to the right location
			_go.transform.position = GOLocationSpot.position;
			// and we hide it for now.
			_go.SetActive(false);
		}
		
		for (int i = 0; i < Players.Count; i++) {
			GameObject player = (GameObject)Instantiate(Players[i].playerIcon, GOLocationSpot.position, Quaternion.Euler(0,210,0));
		}
		
		// now show the first
		ShowID(0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
            SceneManager.LoadScene("MainMenu");
		}
	}
	
	public void ShowNext(){
		ShowID(_currentID+1);
	}
	
	public void ShowPrevious(){
		ShowID(_currentID-1);
	}
	
	void ShowID(int ID){
		
		//if (ID >= GOList.Length){
		if (ID >= Players.Count){
			ID = 0;
		}else if (ID < 0){
			//ID = GOList.Length-1;
			ID = Players.Count-1;
		}
		
		// hide the current
		GOList[_currentID].SetActive (false);
		
		// now store the new ID as being the current
		_currentID = ID;
		GOList[_currentID].SetActive(true);
		//Debug.Log (_currentID);
		
	}// ShowID
	
	public void SelectCharacter(){
		// Save player choice and move to game scene
		PlayerPrefs.SetString("Player", Players[_currentID].playerName);
        //Debug.Log("Selected: " + PlayerPrefs.GetString("Player"));
        SceneManager.LoadScene("PixelSwitch");
	}
}
