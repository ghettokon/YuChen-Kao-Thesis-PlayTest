using UnityEngine;
using System.Collections;

public class showPortal11 : MonoBehaviour {
	
	public GameObject text1;
	public GameObject text2;
	public GameObject textBg;
	
	public bool turnOn = false;
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		
		if (turnOn) {
			text1.GetComponent<MeshRenderer>().enabled = true;
			text2.GetComponent<MeshRenderer>().enabled = true;
			text1.GetComponent<BoxCollider2D>().enabled = true;
			text2.GetComponent<BoxCollider2D>().enabled = true;
			textBg.GetComponent<SpriteRenderer>().enabled = true;
		} else {
			text1.GetComponent<MeshRenderer>().enabled = false;
			text2.GetComponent<MeshRenderer>().enabled = false;
			text1.GetComponent<BoxCollider2D>().enabled = false;
			text2.GetComponent<BoxCollider2D>().enabled = false;
			textBg.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
