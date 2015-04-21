using UnityEngine;
using System.Collections;

public class closeBasement07_1O : MonoBehaviour {

	public GameObject close;
	public GameObject open;
	public GameObject portal;
	public GameObject sound;
	
	void OnMouseUpAsButton(){
		sound.audio.Play ();
		close.GetComponent<SpriteRenderer>().enabled = true;
		close.GetComponent<BoxCollider2D> ().enabled = true;
		open.GetComponent<SpriteRenderer>().enabled = false;
		open.GetComponent<BoxCollider2D> ().enabled = false;
		portal.GetComponent<BoxCollider2D> ().enabled = false;
	}
}
