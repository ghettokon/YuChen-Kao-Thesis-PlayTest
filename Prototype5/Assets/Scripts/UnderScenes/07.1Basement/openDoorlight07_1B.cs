using UnityEngine;
using System.Collections;

public class openDoorlight07_1B : MonoBehaviour {

	public GameObject doorlight;
	public Sprite on;
	public Sprite off;
	public GameObject doorlightL;
	public GameObject dark1;

	public bool turnOn = false;

	void OnMouseUpAsButton(){
		turnOn = !turnOn;

		if (turnOn) {
			doorlight.GetComponent<SpriteRenderer>().sprite = on;
			doorlightL.GetComponent<SpriteRenderer>().enabled = true;
			dark1.GetComponent<SpriteRenderer>().enabled = false;
		} else {
			doorlight.GetComponent<SpriteRenderer>().sprite = off;
			doorlightL.GetComponent<SpriteRenderer>().enabled = false;
			dark1.GetComponent<SpriteRenderer>().enabled = true;
		}
	}
}
