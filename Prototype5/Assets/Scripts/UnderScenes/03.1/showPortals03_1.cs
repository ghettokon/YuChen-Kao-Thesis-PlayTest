using UnityEngine;
using System.Collections;

public class showPortals03_1 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	
	public bool turnOff = true;
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			text1.GetComponent<MeshRenderer>().enabled = false;
			text1.GetComponent<BoxCollider2D>().enabled = false;
			text2.GetComponent<MeshRenderer>().enabled = false;
			text2.GetComponent<BoxCollider2D>().enabled = false;

		} else {
			text1.GetComponent<MeshRenderer>().enabled = true;
			text1.GetComponent<BoxCollider2D>().enabled = true;
			text2.GetComponent<MeshRenderer>().enabled = true;
			text2.GetComponent<BoxCollider2D>().enabled = true;
		}
	}
}
