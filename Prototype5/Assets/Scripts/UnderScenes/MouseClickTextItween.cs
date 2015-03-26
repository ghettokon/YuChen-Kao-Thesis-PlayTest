using UnityEngine;
using System.Collections;

public class MouseClickTextItween : MonoBehaviour {

	public GameObject text;
	
	public bool turnOff = true;
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			text.GetComponent<MeshRenderer>().enabled = false;
		} else {
			text.GetComponent<MeshRenderer>().enabled = true;
			iTween.FadeFrom (text, iTween.Hash ("alpha", 255, "time", 1f));
		}
	}
}
