using UnityEngine;
using System.Collections;

//switch doorlight

public class SwitchR08_3 : MonoBehaviour {

	public bool turnOn = false;
	public GameObject doorlight;
	public GameObject switcher;
	public Sprite switcherOn;
	public Sprite switcherOff;
	public GameObject clickSound;

	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		clickSound.audio.Play();
		if (turnOn) {
			doorlight.GetComponent<SpriteRenderer>().enabled = true;
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOn;
		} else {
			doorlight.GetComponent<SpriteRenderer>().enabled = false;
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOff;
		}
	}

}
