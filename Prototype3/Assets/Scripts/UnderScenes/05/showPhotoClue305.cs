using UnityEngine;
using System.Collections;

public class showPhotoClue305: MonoBehaviour {

	public GameObject bookclue;
	public bool turnOff = true;

	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			bookclue.GetComponent<SpriteRenderer>().enabled = false;
			bookclue.GetComponent<BoxCollider2D> ().enabled = false;
		} else {
			bookclue.GetComponent<SpriteRenderer>().enabled = true;
			bookclue.GetComponent<BoxCollider2D> ().enabled = true;
		}
	}
}
