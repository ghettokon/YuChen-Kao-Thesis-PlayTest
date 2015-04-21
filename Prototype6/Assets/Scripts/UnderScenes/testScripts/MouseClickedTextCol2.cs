using UnityEngine;
using System.Collections;

public class MouseClickedTextCol2 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject textBG1;
	public GameObject textBG2;
	
	void OnMouseUpAsButton(){
		text1.GetComponent<MeshRenderer>().enabled = false;
		text1.GetComponent<BoxCollider2D>().enabled = false;
		text2.GetComponent<MeshRenderer>().enabled = true;
		text2.GetComponent<BoxCollider2D>().enabled = true;
		textBG1.GetComponent<SpriteRenderer>().enabled = false;
		textBG2.GetComponent<SpriteRenderer>().enabled = true;
	}
}
