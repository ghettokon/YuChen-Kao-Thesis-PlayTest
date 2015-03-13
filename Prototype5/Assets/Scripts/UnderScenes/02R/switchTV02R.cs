using UnityEngine;
using System.Collections;

public class switchTV02R : MonoBehaviour {

	public GameObject switcher;
	public GameObject screen;
	public Sprite tvSwitchL;
	public Sprite tvSwitchR;
	public GameObject tvSound;

	//control showup
	public GameObject message;

	public bool open;

	void OnMouseUpAsButton(){
		open = !open;

		if (open) {
			switcher.GetComponent<SpriteRenderer>().sprite = tvSwitchR;
			screen.GetComponent<SpriteRenderer> ().enabled = true;
			tvSound.audio.Play();
		} else {
			switcher.GetComponent<SpriteRenderer>().sprite = tvSwitchL;
			screen.GetComponent<SpriteRenderer> ().enabled = false;
			tvSound.audio.Stop();
			message.GetComponent<SpriteRenderer> ().enabled = false;
		}
	}


}
