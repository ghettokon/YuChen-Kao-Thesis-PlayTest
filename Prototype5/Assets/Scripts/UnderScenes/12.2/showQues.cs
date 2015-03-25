using UnityEngine;
using System.Collections;

public class showQues : MonoBehaviour {

	public GameObject text;
	public GameObject textBG;
	
	public bool turnOff = true;
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			text.GetComponent<MeshRenderer>().enabled = false;
			text.GetComponent<BoxCollider2D> ().enabled = false;
			textBG.GetComponent<SpriteRenderer>().enabled = false;
		} else {
			text.GetComponent<MeshRenderer>().enabled = true;
			text.GetComponent<BoxCollider2D> ().enabled = true;
			textBG.GetComponent<SpriteRenderer>().enabled = true;
		}
	}

}
