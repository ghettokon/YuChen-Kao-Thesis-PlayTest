using UnityEngine;
using System.Collections;

public class switchCover02R : MonoBehaviour {

	public GameObject cover;
	public Sprite cover1;
	public Sprite cover2;
	public GameObject DNCollider;
	public GameObject Cover0Collider;
	
	public bool coverOpen = false;
	
	public GameObject switchSound;
	
	
	void OnMouseUpAsButton(){
		coverOpen = !coverOpen;
		switchSound.audio.Play();
		if (coverOpen) {
			cover.GetComponent<SpriteRenderer>().sprite = cover2;
			DNCollider.GetComponent<BoxCollider2D> ().enabled = true;
			Cover0Collider.GetComponent<BoxCollider2D> ().enabled = false;
			GameObject.Find ("02R-cover-collider0").GetComponent<switchCover202R> ().coverOpen = true;	
		} else {
			cover.GetComponent<SpriteRenderer>().sprite = cover1;
			DNCollider.GetComponent<BoxCollider2D> ().enabled = false;
			Cover0Collider.GetComponent<BoxCollider2D> ().enabled = true;
			GameObject.Find ("02R-cover-collider0").GetComponent<switchCover202R> ().coverOpen = false;
		}
	}
}
