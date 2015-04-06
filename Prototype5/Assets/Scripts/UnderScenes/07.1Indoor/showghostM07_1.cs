using UnityEngine;
using System.Collections;

public class showghostM07_1 : MonoBehaviour {

	public GameObject ghostM;
	public GameObject ghostMtext;
	
	void Update () {
		if (!GameObject.Find ("07.1-switchR").GetComponent<SwitchR07> ().turnOn) {
			if (!GameObject.Find ("07.1-switchL").GetComponent<SwitchL07> ().turnOff) {
				ghostM.GetComponent<SpriteRenderer> ().enabled = true;
				ghostM.GetComponent<BoxCollider2D> ().enabled = true;
			}
		} 
		else {
			ghostM.GetComponent<SpriteRenderer> ().enabled = false;
			ghostM.GetComponent<BoxCollider2D> ().enabled = false;
			//ghostMtext.GetComponent<MeshRenderer>().enabled = false;
			//ghostMtext.GetComponent<BoxCollider2D> ().enabled = false;
		}
	}
}
