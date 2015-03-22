using UnityEngine;
using System.Collections;

public class showRalph08_3 : MonoBehaviour {

	public GameObject ghostRalph;
	public GameObject RDark;
	public GameObject RText;
	
	public bool turnOn = false;

	void Start () {
	
	}
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		if (turnOn) {
			ghostRalph.GetComponent<SpriteRenderer>().enabled = true;
			ghostRalph.GetComponent<BoxCollider2D>().enabled = true;
			RDark.GetComponent<SpriteRenderer>().enabled = true;
		} else {
			ghostRalph.GetComponent<SpriteRenderer>().enabled = false;
			ghostRalph.GetComponent<BoxCollider2D>().enabled = false;
			RDark.GetComponent<SpriteRenderer>().enabled = false;
			RText.GetComponent<MeshRenderer>().enabled = false;
			RText.GetComponent<BoxCollider2D>().enabled = false;
		}
	}
}
