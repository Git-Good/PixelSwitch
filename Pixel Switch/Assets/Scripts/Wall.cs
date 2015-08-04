using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public Vector3 speed;
	public float maxSpeed;
	public int poseWall;

	bool lose = false;

	void Start(){

	}

	void FixedUpdate(){
		if (!lose) {
			velocity += speed * Time.deltaTime;
			velocity = Vector3.ClampMagnitude (velocity, maxSpeed);
			transform.position += velocity * Time.deltaTime;
		}
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			GameController gc = GameObject.FindObjectOfType<GameController>();
			if (gc.poseNum != poseWall){
				Debug.Log ("Lose");
				lose = true;
			}
		}

		if (collider.tag == "Destroy") {
			Destroy (gameObject);
		}
	}
}
