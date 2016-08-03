using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	public static GameController Instance;

	public int poseNum = 0;
	public AudioClip thudSound;
	public AudioClip switchSound;

	GameObject button1, button2, button3, button4;

	AudioSource thud;
	AudioSource success;
	AudioSource switchEffect;


	void Awake() {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		Instance = this;
		thud = GetComponent<AudioSource> ();
		switchEffect = GetComponent<AudioSource> ();
	}

	public void MapButtons(){
		button1 = GameObject.Find ("Pose1");
		button2 = GameObject.Find ("Pose2");
		button3 = GameObject.Find ("Pose3");
		button4 = GameObject.Find ("Pose4");
		
		UnityEngine.Events.UnityAction Pose1 = () => {
			this.PoseOne();};
		button1.GetComponent<Button> ().onClick.AddListener (Pose1);
		
		UnityEngine.Events.UnityAction Pose2 = () => {
			this.PoseTwo();};
		button2.GetComponent<Button> ().onClick.AddListener (Pose2);
		
		UnityEngine.Events.UnityAction Pose3 = () => {
			this.PoseThree();};
		button3.GetComponent<Button> ().onClick.AddListener (Pose3);
		
		UnityEngine.Events.UnityAction Pose4 = () => {
			this.PoseFour();};
		button4.GetComponent<Button> ().onClick.AddListener (Pose4);
	}

	public void PoseOne() {
        poseNum = 1;
        ResetTriggers ();
        GetComponent<Animator> ().SetTrigger ("Pose1");
	}

	public void PoseTwo(){
        poseNum = 2;
        ResetTriggers ();
        GetComponent<Animator> ().SetTrigger ("Pose2");
	}

	public void PoseThree(){
        poseNum = 3;
        ResetTriggers ();
        GetComponent<Animator> ().SetTrigger ("Pose3");
	}

	public void PoseFour(){
        poseNum = 4;
        ResetTriggers ();
        GetComponent<Animator> ().SetTrigger ("Pose4");
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
			ShowEnd showEnd = GameObject.FindObjectOfType<ShowEnd>();
			if (wall.poseWall != poseNum) {
				thud.PlayOneShot(thudSound);
				GetComponent<Animator>().SetTrigger ("Lose");
				wall.LostGame();
				showEnd.Show();
			}
		}
	}
}
