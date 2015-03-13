using UnityEngine;
using System.Collections;

public class switcher01 : MonoBehaviour {

	public GameObject filterL;
	public GameObject lamplight;
	public GameObject switcher;
	public Sprite switcherOn;
	public Sprite switcherOff;
	public bool turnOn = true;
	public GameObject clickSound;
	public GameObject ghostSound;

	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		clickSound.audio.Play();
		if (turnOn) {
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOn;
			lamplight.GetComponent<SpriteRenderer>().enabled = true;
			filterL.GetComponent<SpriteRenderer>().enabled = true;
			ghostSound.audio.Stop();
		} else {
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOff;
			lamplight.GetComponent<SpriteRenderer>().enabled = false;
			filterL.GetComponent<SpriteRenderer>().enabled = false;
			if (!GameObject.Find ("01-DN-collider").GetComponent<switchDN01> ().IsDay) {
				ghostSound.audio.Play();
			}

		}
	}

}
