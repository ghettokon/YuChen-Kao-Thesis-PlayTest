using UnityEngine;
using System.Collections;

public class showghostM07_3 : MonoBehaviour {

	public GameObject ghostM;
	public GameObject ghostMtext;
	
	void Update () {
		if (!GameObject.Find ("07.3-switchR").GetComponent<SwitchR05> ().turnOn) {
			if (!GameObject.Find ("07.3-switchL").GetComponent<SwitchL05> ().turnOff) {
				ghostM.GetComponent<SpriteRenderer> ().enabled = true;
				ghostM.GetComponent<BoxCollider2D> ().enabled = true;
			}
		} 
		else {
			ghostM.GetComponent<SpriteRenderer> ().enabled = false;
			ghostM.GetComponent<BoxCollider2D> ().enabled = false;
			ghostMtext.GetComponent<MeshRenderer>().enabled = false;
			ghostMtext.GetComponent<BoxCollider2D> ().enabled = false;
		}
	}
}
