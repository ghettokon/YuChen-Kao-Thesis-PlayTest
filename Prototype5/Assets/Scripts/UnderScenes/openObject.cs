using UnityEngine;
using System.Collections;

public class openObject : MonoBehaviour {

	public GameObject theObject;
	
	public bool turnOn = false;
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		if (turnOn) {
			theObject.GetComponent<SpriteRenderer>().enabled = true;
			theObject.GetComponent<BoxCollider2D>().enabled = true;
		} else {
			theObject.GetComponent<SpriteRenderer>().enabled = false;
			theObject.GetComponent<BoxCollider2D>().enabled = false;
		}
	}
}
