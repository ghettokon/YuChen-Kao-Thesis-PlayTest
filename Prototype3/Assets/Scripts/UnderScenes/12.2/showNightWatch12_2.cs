using UnityEngine;
using System.Collections;

public class showNightWatch12_2 : MonoBehaviour {

	public GameObject nightWatch;
	public bool turnOff = true;

	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			nightWatch.GetComponent<SpriteRenderer>().enabled = false;
			nightWatch.GetComponent<BoxCollider2D> ().enabled = false;
		} else {
			nightWatch.GetComponent<SpriteRenderer>().enabled = true;
			nightWatch.GetComponent<BoxCollider2D> ().enabled = true;
		}
	}

}
