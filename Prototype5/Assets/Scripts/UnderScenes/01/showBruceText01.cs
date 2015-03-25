using UnityEngine;
using System.Collections;

public class showBruceText01 : MonoBehaviour {

	public GameObject BruceText1;
	public GameObject MaryText1;
	public GameObject MaryCollider;
	public GameObject textBgMary1;
	public GameObject textBG;

	
	void OnMouseUpAsButton(){
		BruceText1.GetComponent<MeshRenderer>().enabled = true;
		BruceText1.GetComponent<BoxCollider2D> ().enabled = true;
		textBG.GetComponent<SpriteRenderer>().enabled = true;
		MaryText1.GetComponent<MeshRenderer>().enabled = false;
		MaryText1.GetComponent<BoxCollider2D> ().enabled = false;
		MaryCollider.GetComponent<BoxCollider2D> ().enabled = false;
		textBgMary1.GetComponent<SpriteRenderer>().enabled = false;

	}
}
