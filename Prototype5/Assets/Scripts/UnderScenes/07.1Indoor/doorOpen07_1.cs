using UnityEngine;
using System.Collections;

public class doorOpen07_1 : MonoBehaviour {

	public GameObject door;
	public GameObject doorOpen;
	public GameObject outsideCol;
	public GameObject sound;
	
	void OnMouseUpAsButton(){
		sound.audio.Play ();
		door.GetComponent<SpriteRenderer>().enabled = false;
		door.GetComponent<BoxCollider2D>().enabled = false;
		doorOpen.GetComponent<SpriteRenderer>().enabled = true;
		doorOpen.GetComponent<BoxCollider2D>().enabled = true;
		outsideCol.GetComponent<BoxCollider2D>().enabled = true;
	}
}
