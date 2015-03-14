using UnityEngine;
using System.Collections;

public class openLampLight07_1B : MonoBehaviour {

	public GameObject lampLight;
	public GameObject dark2;
	
	public bool turnOn = false;
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		
		if (turnOn) {
			lampLight.GetComponent<SpriteRenderer>().enabled = true;
			dark2.GetComponent<SpriteRenderer>().enabled = false;
		} else {
			lampLight.GetComponent<SpriteRenderer>().enabled = false;
			dark2.GetComponent<SpriteRenderer>().enabled = true;
		}
	}
}
