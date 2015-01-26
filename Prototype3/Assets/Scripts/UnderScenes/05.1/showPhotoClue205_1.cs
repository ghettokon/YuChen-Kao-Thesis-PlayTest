using UnityEngine;
using System.Collections;

public class showPhotoClue205_1 : MonoBehaviour {

	public GameObject photoclue;
	public bool turnOff = true;

	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			photoclue.GetComponent<SpriteRenderer>().enabled = false;
			photoclue.GetComponent<BoxCollider2D> ().enabled = false;
		} else {
			photoclue.GetComponent<SpriteRenderer>().enabled = true;
			photoclue.GetComponent<BoxCollider2D> ().enabled = true;
		}

	}
}
