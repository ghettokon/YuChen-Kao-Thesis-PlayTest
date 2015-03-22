using UnityEngine;
using System.Collections;

public class showPortal05 : MonoBehaviour {

	public GameObject text;

	public bool turnOff = true;

	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			text.GetComponent<MeshRenderer>().enabled = false;
			text.GetComponent<BoxCollider2D> ().enabled = false;

		} else {
			text.GetComponent<MeshRenderer>().enabled = true;
			text.GetComponent<BoxCollider2D> ().enabled = true;
			iTween.FadeFrom (gameObject, iTween.Hash ("alpha", 0, "time", 5f));
		}
	}

}
