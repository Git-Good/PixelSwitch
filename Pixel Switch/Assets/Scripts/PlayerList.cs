using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerList : MonoBehaviour {
	public List<Player> players = new List<Player>();
	
	void Start(){
		players.Add (new Player("Pink", 0));
		players.Add (new Player("Banana", 1));
		players.Add (new Player("Bones", 2));
        players.Add (new Player("Santa", 3));
	}
}
