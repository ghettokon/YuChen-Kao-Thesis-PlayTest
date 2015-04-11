using UnityEngine;
using System.Collections;

public class MouseClickedTextCol : MonoBehaviour {

	public GameObject text;
	public GameObject textBg;
	
	public bool turnOff = true;
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			text.GetComponent<MeshRenderer>().enabled = false;
			text.GetComponent<BoxCollider2D>().enabled = false;
			textBg.GetComponent<SpriteRenderer>().enabled = false;

		} else {
			text.GetComponent<MeshRenderer>().enabled = true;
			text.GetComponent<BoxCollider2D>().enabled = true;
			textBg.GetComponent<SpriteRenderer>().enabled = true;
		}
	}
}
