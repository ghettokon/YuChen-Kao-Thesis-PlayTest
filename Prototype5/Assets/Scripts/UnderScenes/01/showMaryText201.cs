using UnityEngine;
using System.Collections;

public class showMaryText201 : MonoBehaviour {

	public GameObject BruceText1;
	public GameObject MaryText2;
	public GameObject textBgBruce;
	public GameObject textBG;
	
	
	void OnMouseUpAsButton(){
		BruceText1.GetComponent<MeshRenderer>().enabled = false;
		BruceText1.GetComponent<BoxCollider2D> ().enabled = false;
		MaryText2.GetComponent<MeshRenderer>().enabled = true;
		MaryText2.GetComponent<BoxCollider2D> ().enabled = true;
		textBgBruce.GetComponent<SpriteRenderer>().enabled = false;
		textBG.GetComponent<SpriteRenderer>().enabled = true;
	}
}
