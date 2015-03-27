using UnityEngine;
using System.Collections;

public class turnKey09 : MonoBehaviour {

	public GameObject keyOff;
	public GameObject keyOn;
	public GameObject drivSound;
	public GameObject bg;
	public GameObject Mary1;
	public GameObject Mary2;
	public GameObject text2;
	public GameObject textBg;
	public GameObject turnKeySound;

	public bool turnOn;
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;


		if (turnOn) {
			turnKeySound.audio.Play ();
			keyOn.GetComponent<SpriteRenderer>().enabled = true;
			keyOff.GetComponent<SpriteRenderer>().enabled = false;
			if(GameObject.Find ("09-carForward-collider").GetComponent<control09> ().turnOn){
				drivSound.audio.Play();
			}
		} else {
			keyOn.GetComponent<SpriteRenderer>().enabled = false;
			keyOff.GetComponent<SpriteRenderer>().enabled = true;
			drivSound.audio.Stop();
			bg.GetComponent<Animator>().enabled = false;
			Mary1.GetComponent<BoxCollider2D>().enabled = true;
			Mary2.GetComponent<BoxCollider2D>().enabled = false;
			text2.GetComponent<BoxCollider2D>().enabled = false;
			text2.GetComponent<MeshRenderer>().enabled = false;
			GameObject.Find ("09-Mary-collider1").GetComponent<MouseClickText> ().turnOff = false;
			textBg.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
