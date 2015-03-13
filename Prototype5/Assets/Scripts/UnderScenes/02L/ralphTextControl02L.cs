using UnityEngine;
using System.Collections;

public class ralphTextControl02L : MonoBehaviour {

	public GameObject Rtext1;
	public GameObject Rtext2;

	public bool turnOn = true;

	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		if (turnOn) {
			Rtext1.GetComponent<MeshRenderer>().enabled = true;
			Rtext1.GetComponent<BoxCollider2D> ().enabled = true;
			Rtext2.GetComponent<MeshRenderer>().enabled = true;
			Rtext2.GetComponent<BoxCollider2D> ().enabled = true;
		} else {
			Rtext1.GetComponent<MeshRenderer>().enabled = false;
			Rtext1.GetComponent<BoxCollider2D> ().enabled = false;
			Rtext2.GetComponent<MeshRenderer>().enabled = false;
			Rtext2.GetComponent<BoxCollider2D> ().enabled = false;
		}
	}


	
}
