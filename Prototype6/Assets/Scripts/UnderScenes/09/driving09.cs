using UnityEngine;
using System.Collections;

public class driving09 : MonoBehaviour {

	public GameObject bg;
	public GameObject Mary1;
	public GameObject Mary2;
	public GameObject text1;

	void Update () {
		if (GameObject.Find ("09-carKey-collider").GetComponent<turnKey09> ().turnOn) {
			if (GameObject.Find ("09-carForward-collider").GetComponent<control09> ().turnOn) {
				bg.GetComponent<Animator>().enabled = true;
				Mary1.GetComponent<BoxCollider2D>().enabled = false;
				Mary2.GetComponent<BoxCollider2D>().enabled = true;
				text1.GetComponent<MeshRenderer>().enabled = false;
			}
		}
		else {
			bg.GetComponent<Animator>().enabled = false;
			Mary1.GetComponent<BoxCollider2D>().enabled = true;
			Mary2.GetComponent<BoxCollider2D>().enabled = false;
			//GameObject.Find ("09-Mary-collider1").GetComponent<MouseClickText> ().turnOff = true;
		}
	}
}
