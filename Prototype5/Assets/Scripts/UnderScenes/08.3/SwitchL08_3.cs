using UnityEngine;
using System.Collections;

//switch livingroomlight(filterDark)

public class SwitchL08_3 : MonoBehaviour {

	public bool turnOff = true;
	public GameObject filterDark;
	public GameObject lamplight;
	public GameObject switcher;
	public Sprite switcherOn;
	public Sprite switcherOff;
	public GameObject clickSound;

	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		clickSound.audio.Play();
		if (turnOff) {
			filterDark.GetComponent<SpriteRenderer>().enabled = true;
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOff;
			lamplight.GetComponent<SpriteRenderer>().enabled = false;
		} else {
			filterDark.GetComponent<SpriteRenderer>().enabled = false;
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOn;
			lamplight.GetComponent<SpriteRenderer>().enabled = true;
		}
	}
}
