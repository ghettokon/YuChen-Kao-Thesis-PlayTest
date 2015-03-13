using UnityEngine;
using System.Collections;

public class showDayWatch12_2 : MonoBehaviour {

	public GameObject dayWatch;
	public bool turnOff = true;

	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			dayWatch.GetComponent<SpriteRenderer>().enabled = false;
			dayWatch.GetComponent<BoxCollider2D> ().enabled = false;
		} else {
			dayWatch.GetComponent<SpriteRenderer>().enabled = true;
			dayWatch.GetComponent<BoxCollider2D> ().enabled = true;
		}
	}

}
