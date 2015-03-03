using UnityEngine;
using System.Collections;

//switch doorlight

public class SwitchR05 : MonoBehaviour {

	public GameObject doorlight;
	public GameObject switcher;
	public Sprite switcherOn;
	public Sprite switcherOff;
	public bool turnOn = true;
	public GameObject clickSound;
	public GameObject MGhost;
	public GameObject MGhostText;

	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		clickSound.audio.Play();
		if (turnOn) {
			doorlight.GetComponent<SpriteRenderer>().enabled = true;
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOn;
			MGhost.GetComponent<SpriteRenderer>().enabled = false;
			MGhost.GetComponent<BoxCollider2D> ().enabled = false;
			MGhostText.GetComponent<MeshRenderer>().enabled = false;
			MGhostText.GetComponent<BoxCollider2D> ().enabled = false;
		} else {
			doorlight.GetComponent<SpriteRenderer>().enabled = false;
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOff;
		}
	}

}
