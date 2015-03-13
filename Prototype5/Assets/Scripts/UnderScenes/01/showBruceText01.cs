using UnityEngine;
using System.Collections;

public class showBruceText01 : MonoBehaviour {

	public GameObject BruceText1;
	public GameObject MaryText1;
	public GameObject MaryCollider;

	
	void OnMouseUpAsButton(){
		BruceText1.GetComponent<MeshRenderer>().enabled = true;
		BruceText1.GetComponent<BoxCollider2D> ().enabled = true;
		MaryText1.GetComponent<MeshRenderer>().enabled = false;
		MaryText1.GetComponent<BoxCollider2D> ().enabled = false;
		MaryCollider.GetComponent<BoxCollider2D> ().enabled = false;
	}
}
