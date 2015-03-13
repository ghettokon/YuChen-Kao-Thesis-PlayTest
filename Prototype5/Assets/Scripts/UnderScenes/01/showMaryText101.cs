using UnityEngine;
using System.Collections;

public class showMaryText101 : MonoBehaviour {

	public GameObject MaryText1;
	
	public bool turnOff = true;
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			MaryText1.GetComponent<MeshRenderer>().enabled = false;
			MaryText1.GetComponent<BoxCollider2D> ().enabled = false;
		} else {
			MaryText1.GetComponent<MeshRenderer>().enabled = true;
			MaryText1.GetComponent<BoxCollider2D> ().enabled = true;
		}
	}
}
