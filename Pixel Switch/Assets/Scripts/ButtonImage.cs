using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonImage : MonoBehaviour {

	public Button button1, button2, button3, button4;

	public void ButtonImageChange(){
		button1.image.sprite = Resources.Load<Sprite> ("Text and Images/Buttons/" + PlayerPrefs.GetString ("Player") + "1");
		button2.image.sprite = Resources.Load<Sprite> ("Text and Images/Buttons/" + PlayerPrefs.GetString ("Player") + "2");
		button3.image.sprite = Resources.Load<Sprite> ("Text and Images/Buttons/" + PlayerPrefs.GetString ("Player") + "3");
		button4.image.sprite = Resources.Load<Sprite> ("Text and Images/Buttons/" + PlayerPrefs.GetString ("Player") + "4");
	}
}
