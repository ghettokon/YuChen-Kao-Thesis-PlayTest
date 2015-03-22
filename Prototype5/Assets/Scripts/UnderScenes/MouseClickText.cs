using UnityEngine;
using System.Collections;

public class MouseClickText : MonoBehaviour {

	public GameObject text;

	public bool turnOff = true;
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			text.GetComponent<MeshRenderer>().enabled = false;
			//GameObject.Find ("05-Bruce-text").GetComponent<MouseClickText> ().turnOff = true;
		} else {
			text.GetComponent<MeshRenderer>().enabled = true;
			//iTween.FadeFrom (text, iTween.Hash ("alpha", 255, "time", 1f));
		}
	}

}
