using UnityEngine;
using System.Collections;

public class openBox07_1B : MonoBehaviour {

	public GameObject box1;
	public GameObject box2;
	public GameObject key;
	public GameObject sound;

	void OnMouseUpAsButton(){
		sound.audio.Play ();
		box1.GetComponent<SpriteRenderer>().enabled = false;
		box1.GetComponent<BoxCollider2D>().enabled = false;
		box2.GetComponent<SpriteRenderer>().enabled = true;
		key.GetComponent<SpriteRenderer>().enabled = true;
		key.GetComponent<BoxCollider2D>().enabled = true;
	}

}
