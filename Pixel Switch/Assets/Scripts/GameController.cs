using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int poseNum = 0;
	public GameObject EndCard;
	public AudioClip thudSound;
	public AudioClip successSound;
	public AudioClip switchSound;

	AudioSource thud;
	AudioSource success;
	AudioSource switchEffect;


	void Awake() {
		success = GetComponent<AudioSource> ();
		thud = GetComponent<AudioSource> ();
		switchEffect = GetComponent<AudioSource> ();
	}

	void Start() {
		success.clip = successSound;
	}

	public void PoseOne() {
		ResetTriggers ();
		GetComponent<Animator> ().SetTrigger ("Pose1");
		poseNum = 1;
	}

	public void PoseTwo(){
		ResetTriggers ();
		GetComponent<Animator> ().SetTrigger ("Pose2");
		poseNum = 2;
	}

	public void PoseThree(){
		ResetTriggers ();
		GetComponent<Animator> ().SetTrigger ("Pose3");
		poseNum = 3;
	}

	public void PoseFour(){
		ResetTriggers ();
		GetComponent<Animator> ().SetTrigger ("Pose4");
		poseNum = 4;
	}

	void ResetTriggers () {
		GetComponent<Animator>().ResetTrigger ("Pose1");
		GetComponent<Animator>().ResetTrigger ("Pose2");
		GetComponent<Animator>().ResetTrigger ("Pose3");
		GetComponent<Animator>().ResetTrigger ("Pose4");
		switchEffect.PlayOneShot (switchSound);
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Wall") {
			Wall wall = GameObject.FindObjectOfType<Wall> ();
			if (wall.poseWall != poseNum) {
				thud.PlayOneShot(thudSound);
				GetComponent<Animator>().SetTrigger ("Lose");
				wall.LostGame();
				StartCoroutine (DelayActive(1f));
			}
			else {
				if (!success.isPlaying){
					success.Play ();
				}
			}
		}
	}

	private IEnumerator DelayActive (float duration) {
		yield return new WaitForSeconds(duration);
		EndCard.SetActive (true);
	}
}
