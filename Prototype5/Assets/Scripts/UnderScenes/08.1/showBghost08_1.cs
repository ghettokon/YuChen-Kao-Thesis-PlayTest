using UnityEngine;
using System.Collections;

public class showBghost08_1 : MonoBehaviour {

	public GameObject ghost;
	public GameObject BDark;
	public GameObject text;
	
	public bool turnOn = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		
		if (turnOn) {
			ghost.GetComponent<SpriteRenderer> ().enabled = true;
			BDark.GetComponent<SpriteRenderer> ().enabled = true;
			text.GetComponent<MeshRenderer> ().enabled = true;
			text.GetComponent<BoxCollider2D> ().enabled = true;
		} else {
			ghost.GetComponent<SpriteRenderer> ().enabled = false;
			BDark.GetComponent<SpriteRenderer> ().enabled = false;
			text.GetComponent<MeshRenderer> ().enabled = false;
			text.GetComponent<BoxCollider2D> ().enabled = false;
		}
	}
}
