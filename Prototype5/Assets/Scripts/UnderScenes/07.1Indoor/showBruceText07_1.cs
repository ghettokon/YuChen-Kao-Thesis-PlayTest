using UnityEngine;
using System.Collections;

public class showBruceText07_1 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	
	void OnMouseUpAsButton(){
		text1.GetComponent<MeshRenderer>().enabled = false;
		text1.GetComponent<BoxCollider2D>().enabled = false;
		text2.GetComponent<MeshRenderer>().enabled = true;
		GameObject.Find ("07.1-Zoe-collider").GetComponent<MouseClickedTextCol> ().turnOff = true;
		//text2.GetComponent<BoxCollider2D>().enabled = true;
	}
}
