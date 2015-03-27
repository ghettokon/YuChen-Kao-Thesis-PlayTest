using UnityEngine;
using System.Collections;

public class getKey07_1B : MonoBehaviour {

	public GameObject key;
	public GameObject shelfCollider1;
	public GameObject shelfCollider2;
	public GameObject getSound;

	void OnMouseUpAsButton(){
		getSound.audio.Play ();
		key.GetComponent<SpriteRenderer>().enabled = false;
		key.GetComponent<BoxCollider2D>().enabled = false;
		shelfCollider1.GetComponent<BoxCollider2D>().enabled = false;
		shelfCollider2.GetComponent<BoxCollider2D>().enabled = true;
	}
}
