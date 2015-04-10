using UnityEngine;
using System.Collections;

public class switcherL02L : MonoBehaviour {

	public GameObject filterL;
	public GameObject lamplight;
	public GameObject switcher;
	public Sprite switcherOn;
	public Sprite switcherOff;
	public bool turnOn = true;
	public GameObject clickSound;

	public GameObject mirror;
	public Sprite mirror1;
	public Sprite mirror2;
	public GameObject Gtext;

	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		clickSound.audio.Play();
		if (turnOn) {
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOn;
			lamplight.GetComponent<SpriteRenderer>().enabled = true;
			filterL.GetComponent<SpriteRenderer>().enabled = true;
			mirror.GetComponent<SpriteRenderer> ().sprite = mirror1;
			mirror.GetComponent<BoxCollider2D>().enabled = false;
			Gtext.GetComponent<MeshRenderer>().enabled = false;
			GameObject.Find ("02L-mirror").GetComponent<MouseClickTextFade> ().turnOff = true;
		} else {
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOff;
			lamplight.GetComponent<SpriteRenderer>().enabled = false;
			filterL.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
