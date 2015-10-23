using UnityEngine;
using System.Collections;

public class ShowEnd : MonoBehaviour {

	public GameObject EndCard;

	// Use this for initialization
	public void Show () {
		StartCoroutine (DelayActive(1f));
	}

	private IEnumerator DelayActive (float duration) {
		yield return new WaitForSeconds(duration);
		EndCard.SetActive (true);
	}
}
