using UnityEngine;
using System.Collections;

public class openLampLight07_1B : MonoBehaviour {

	public GameObject lampLight;
	public GameObject dark2;
	public GameObject clickSound;
	
	public bool turnOn = false;
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		clickSound.audio.Play ();
		
		if (turnOn) {
			lampLight.GetComponent<SpriteRenderer>().enabled = true;
			dark2.GetComponent<SpriteRenderer>().enabled = false;
		} else {
			lampLight.GetComponent<SpriteRenderer>().enabled = false;
			dark2.GetComponent<SpriteRenderer>().enabled = true;
		}
	}
}
