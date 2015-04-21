using UnityEngine;
using System.Collections;

public class openBasement07_1O : MonoBehaviour {

	public GameObject close;
	public GameObject open;
	public GameObject portal;
	public GameObject sound;

	void OnMouseUpAsButton(){
		sound.audio.Play ();
		close.GetComponent<SpriteRenderer>().enabled = false;
		close.GetComponent<BoxCollider2D> ().enabled = false;
		open.GetComponent<SpriteRenderer>().enabled = true;
		open.GetComponent<BoxCollider2D> ().enabled = true;
		portal.GetComponent<BoxCollider2D> ().enabled = true;
	}
}
