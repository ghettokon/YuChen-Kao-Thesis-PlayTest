using UnityEngine;
using System.Collections;

public class showGhost11 : MonoBehaviour {

	public GameObject Mary;
	public GameObject dark;
	public GameObject text1;
	public GameObject text2;
	
	public bool turnOn = false;
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		
		if (turnOn) {
			Mary.GetComponent<SpriteRenderer>().enabled = true;
			Mary.GetComponent<BoxCollider2D>().enabled = true;
			dark.GetComponent<SpriteRenderer>().enabled = true;
			GameObject.Find ("11-MaryG").GetComponent<showPortal11> ().turnOn = false;
		} else {
			Mary.GetComponent<SpriteRenderer>().enabled = false;
			Mary.GetComponent<BoxCollider2D>().enabled = false;
			dark.GetComponent<SpriteRenderer>().enabled = false;
			text1.GetComponent<MeshRenderer>().enabled = false;
			text2.GetComponent<MeshRenderer>().enabled = false;
			text1.GetComponent<BoxCollider2D>().enabled = false;
			text2.GetComponent<BoxCollider2D>().enabled = false;
		}
	}
}
