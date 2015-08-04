using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	public void ShowUI(){
		GetComponent<Canvas> ().enabled = true;
	}

	public void HideUI(){
		GetComponent<Canvas> ().enabled = false;
	}
}
