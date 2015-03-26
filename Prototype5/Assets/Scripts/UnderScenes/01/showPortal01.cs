using UnityEngine;
using System.Collections;

public class showPortal01 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject textBg;
	
	public bool turnOff = true;
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			text1.GetComponent<MeshRenderer>().enabled = false;
			text2.GetComponent<MeshRenderer>().enabled = false;
			text2.GetComponent<BoxCollider2D> ().enabled = false;
			textBg.GetComponent<SpriteRenderer> ().enabled = false;
		} else {
			text1.GetComponent<MeshRenderer>().enabled = true;
			text2.GetComponent<MeshRenderer>().enabled = true;
			text2.GetComponent<BoxCollider2D> ().enabled = true;
			textBg.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}
