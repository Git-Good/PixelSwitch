using UnityEngine;
using System.Collections;

[System.Serializable]
public class Player {
	public string playerName;
	public int playerID;
	public GameObject playerIcon;
	
	// Instance of the class is created, everything will be called. Constructor.
	public Player(string name, int ID){
		playerName = name;
		playerID = ID;
		playerIcon = Resources.Load<GameObject> ("Text and Images/Players/Player Selector/" + name);
	}
}
