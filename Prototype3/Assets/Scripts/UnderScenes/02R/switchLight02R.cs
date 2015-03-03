using UnityEngine;
using System.Collections;

public class switchLight02R : MonoBehaviour {

	public GameObject filterL;
	public GameObject lamplight;
	public GameObject switcher;
	public Sprite switcherOn;
	public Sprite switcherOff;
	public bool turnOn = true;
	public GameObject clickSound;

	//control left
	public GameObject Rlight;

	//control showup
	public GameObject message;

	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		clickSound.audio.Play();
		if (turnOn) {
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOn;
			lamplight.GetComponent<SpriteRenderer>().enabled = true;
			filterL.GetComponent<SpriteRenderer>().enabled = true;

			//left
			Rlight.GetComponent<SpriteRenderer>().enabled = true;

			//
			message.GetComponent<SpriteRenderer>().enabled = false;
		} else {
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOff;
			lamplight.GetComponent<SpriteRenderer>().enabled = false;
			filterL.GetComponent<SpriteRenderer>().enabled = false;

			//left
			Rlight.GetComponent<SpriteRenderer>().enabled = false;
		}
	}

}
