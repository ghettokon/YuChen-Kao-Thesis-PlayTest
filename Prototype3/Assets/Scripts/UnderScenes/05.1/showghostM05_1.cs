using UnityEngine;
using System.Collections;

public class showghostM05_1 : MonoBehaviour {

	public GameObject ghostM;
	public GameObject ghostMtext;

	void Update () {

		if (!GameObject.Find ("05.1-switchR").GetComponent<SwitchR05_1> ().turnOn) {
			if (!GameObject.Find ("05.1-switchL").GetComponent<SwitchL05_1> ().turnOff) {
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
