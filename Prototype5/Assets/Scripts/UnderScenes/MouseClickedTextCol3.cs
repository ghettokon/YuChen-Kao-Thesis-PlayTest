using UnityEngine;
using System.Collections;

public class MouseClickedTextCol3 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	
	void OnMouseUpAsButton(){
		text1.GetComponent<MeshRenderer>().enabled = false;
		text1.GetComponent<BoxCollider2D>().enabled = false;
		text2.GetComponent<MeshRenderer>().enabled = true;
		text2.GetComponent<BoxCollider2D>().enabled = true;
		text3.GetComponent<MeshRenderer>().enabled = true;
		text3.GetComponent<BoxCollider2D>().enabled = true;
	}
}
