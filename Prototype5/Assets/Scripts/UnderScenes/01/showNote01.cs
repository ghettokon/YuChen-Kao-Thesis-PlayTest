using UnityEngine;
using System.Collections;

public class showNote01 : MonoBehaviour {

	public GameObject noteclue;
	public bool turnOff = true;
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			noteclue.GetComponent<SpriteRenderer>().enabled = false;
			noteclue.GetComponent<BoxCollider2D> ().enabled = false;

		} else {
			noteclue.GetComponent<SpriteRenderer>().enabled = true;
			noteclue.GetComponent<BoxCollider2D> ().enabled = true;
		}
		
	}
}
