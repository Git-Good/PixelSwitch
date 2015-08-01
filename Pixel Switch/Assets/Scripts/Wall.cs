using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public Vector3 speed;
	public float maxSpeed;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		// do updates in GameController
	}

	void FixedUpdate(){
		velocity += speed * Time.deltaTime;

		velocity = Vector3.ClampMagnitude (velocity, maxSpeed);
		transform.position += velocity * Time.deltaTime;
	}
}
