using UnityEngine;
using System.Collections;

public class showPhotoClue305_1: MonoBehaviour {

	public GameObject bookclue;
	public bool turnOff = true;

	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			bookclue.GetComponent<SpriteRenderer>().enabled = false;
		} else {
			bookclue.GetComponent<SpriteRenderer>().enabled = true;
		}
	}
}
