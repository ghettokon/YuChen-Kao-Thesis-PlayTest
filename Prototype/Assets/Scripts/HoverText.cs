using UnityEngine;
using System.Collections;

public class HoverText : MonoBehaviour {

	public GameObject text;

	void OnMouseEnter(){
		text.GetComponent<MeshRenderer>().enabled = true;
	}
		
	void OnMouseExit(){
		text.GetComponent<MeshRenderer> ().enabled = false;
	}

}
