using UnityEngine;
using System.Collections;

public class doorClose07_1 : MonoBehaviour {

	public GameObject door;
	public GameObject doorOpen;
	public GameObject outsideCol;
	public GameObject sound;

	void OnMouseUpAsButton(){
		sound.audio.Play ();
		door.GetComponent<SpriteRenderer>().enabled = true;
		door.GetComponent<BoxCollider2D>().enabled = true;
		doorOpen.GetComponent<SpriteRenderer>().enabled = false;
		doorOpen.GetComponent<BoxCollider2D>().enabled = false;
		outsideCol.GetComponent<BoxCollider2D>().enabled = false;
	}
}
