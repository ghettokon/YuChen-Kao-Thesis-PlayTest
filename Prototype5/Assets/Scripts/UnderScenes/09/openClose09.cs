using UnityEngine;
using System.Collections;

public class openClose09 : MonoBehaviour {

	public GameObject close;
	public GameObject open;
	public GameObject flyerS;
	
	public bool turnOn;
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		
		if (turnOn) {
			open.GetComponent<SpriteRenderer>().enabled = true;
			close.GetComponent<SpriteRenderer>().enabled = false;
			flyerS.GetComponent<SpriteRenderer>().enabled = true;
			flyerS.GetComponent<BoxCollider2D>().enabled = true;
		} else {
			open.GetComponent<SpriteRenderer>().enabled = false;
			close.GetComponent<SpriteRenderer>().enabled = true;
			flyerS.GetComponent<SpriteRenderer>().enabled = false;
			flyerS.GetComponent<BoxCollider2D>().enabled = false;
		}
	}
}
