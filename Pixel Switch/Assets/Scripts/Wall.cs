using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public Vector3 speed;
	public float maxSpeed;
	public int poseWall;
	
	bool lose = false;

	void FixedUpdate(){
		if (!lose) {
			velocity += speed * Time.deltaTime;
			velocity = Vector3.ClampMagnitude (velocity, maxSpeed);
			transform.position += velocity * Time.deltaTime;
		}
	}

	public void LostGame() {
		lose = true;
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Destroy") {
			Destroy (gameObject);
		}
	}
}
