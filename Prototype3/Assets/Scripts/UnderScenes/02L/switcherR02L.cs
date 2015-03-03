using UnityEngine;
using System.Collections;

public class switcherR02L : MonoBehaviour {
	
	public GameObject doorlight;
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
			doorlight.GetComponent<SpriteRenderer>().enabled = true;
			mirror.GetComponent<SpriteRenderer> ().sprite = mirror1;
			mirror.GetComponent<BoxCollider2D>().enabled = false;
			Gtext.GetComponent<MeshRenderer>().enabled = false;
			GameObject.Find ("02L-mirror").GetComponent<MouseClickText> ().turnOff = true;
		} else {
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOff;
			doorlight.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
