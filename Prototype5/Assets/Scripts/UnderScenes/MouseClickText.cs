using UnityEngine;
using System.Collections;

public class MouseClickText : MonoBehaviour {

	public GameObject text;

	public bool turnOff = true;
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			text.GetComponent<MeshRenderer>().enabled = false;
		} else {
			text.GetComponent<MeshRenderer>().enabled = true;
		}
	}

}
