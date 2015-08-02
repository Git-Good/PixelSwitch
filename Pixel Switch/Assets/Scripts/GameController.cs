using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int poseNum = 0;
	bool lose = false;

	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {
		Check ();
	}

	void FixedUpdate(){
		if (lose)
			return;
	}

	public void Check(){

	}


	public void PoseOne() {
		poseNum = 1;

	}

	public void PoseTwo(){
		poseNum = 2;
	}

	public void PoseThree(){
		poseNum = 3;
	}

	public void PoseFour(){
		poseNum = 4;
	}

	void OnCollisionEnter2D(Collision2D collision){
		lose = true;
	}
}
