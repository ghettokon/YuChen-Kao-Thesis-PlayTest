using UnityEngine;
using System.Collections;

public class openlocker07_1 : MonoBehaviour {

	public GameObject shelfCollider2;
	public GameObject shelfOpen;
	public GameObject openSound;

	void OnMouseUpAsButton(){
		openSound.audio.Play ();
		shelfCollider2.GetComponent<BoxCollider2D>().enabled = false;
		shelfOpen.GetComponent<SpriteRenderer>().enabled = true;
		shelfOpen.GetComponent<BoxCollider2D>().enabled = true;
	}
}
