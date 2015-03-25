using UnityEngine;
using System.Collections;

public class control09 : MonoBehaviour {

	public GameObject forward;
	public GameObject back;
	public GameObject drivSound;
	public GameObject bg;
	public GameObject Mary1;
	public GameObject Mary2;
	public GameObject text2;
	public GameObject textBg;
	
	public bool turnOn;
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		
		if (turnOn) {
			forward.GetComponent<SpriteRenderer>().enabled = true;
			back.GetComponent<SpriteRenderer>().enabled = false;
			if(GameObject.Find ("09-carKey-collider").GetComponent<turnKey09> ().turnOn){
				drivSound.audio.Play();
			}
		} else {
			forward.GetComponent<SpriteRenderer>().enabled = false;
			back.GetComponent<SpriteRenderer>().enabled = true;
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
