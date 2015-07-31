using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	John j;
	Wall w;
	bool checker = true;
	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {
		Check ();
		w.MoveWall ();
	}

	public void Check(){
		if (w.xcoord == j.xcoord) { // check only if wall reaches john
			if (w.pose == j.pose) { // check if wall john fits through wall
				checker = true;
			} else {
				checker = false; //end game
			}
		}
	}


	public void PoseOne() {
		j.pose = 1;
		//j.im = po1.bmp;
	}

	public void PoseTwo(){
		j.pose = 2;
		//j.im = po2.bmp;
	}

	public void PoseThree(){
		j.pose = 3;
		//j.im = po3.bmp;
	}

	public void PoseFour(){
		j.pose = 4;
		//j.im = po4.bmp;
	}
}
