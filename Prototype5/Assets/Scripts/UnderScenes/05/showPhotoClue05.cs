using UnityEngine;
using System.Collections;

public class showPhotoClue05 : MonoBehaviour {

	public GameObject dropclue;
	public GameObject Book;
	public GameObject dropbookclueCollider;
	public GameObject dropphotoclueCollider;
	public GameObject fallSound;
	
	void OnMouseUpAsButton(){
		fallSound.audio.Play();
		dropclue.GetComponent<SpriteRenderer>().enabled = true;
		Book.GetComponent<SpriteRenderer>().enabled = false;
		Book.GetComponent<BoxCollider2D> ().enabled = false;
		dropbookclueCollider.GetComponent<BoxCollider2D> ().enabled = true;
		dropphotoclueCollider.GetComponent<BoxCollider2D> ().enabled = true;
	}
}
