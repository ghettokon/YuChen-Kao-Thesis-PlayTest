using UnityEngine;
using System.Collections;

public class showRalphText02L : MonoBehaviour {

	public GameObject Rtext1;
	public GameObject Rtext2;
	public GameObject RCollider;
	public GameObject Mtext;
	public GameObject textBg1;
	public GameObject textBg2;
	//public GameObject MCollider;

	void OnMouseUpAsButton(){
		Rtext1.GetComponent<MeshRenderer>().enabled = true;
		Rtext1.GetComponent<BoxCollider2D> ().enabled = true;
		Rtext2.GetComponent<MeshRenderer>().enabled = true;
		Rtext2.GetComponent<BoxCollider2D> ().enabled = true;
		Mtext.GetComponent<MeshRenderer>().enabled = false;
		Mtext.GetComponent<BoxCollider2D> ().enabled = false;
		RCollider.GetComponent<BoxCollider2D> ().enabled = true;
		GameObject.Find ("02L-Mary-collider").GetComponent<showMaryText02L> ().turnOff = true;
		GameObject.Find ("02L-Ralph-collider").GetComponent<ralphTextControl02L> ().turnOn = true;
		//MCollider.GetComponent<BoxCollider2D> ().enabled = false;
		textBg1.GetComponent<SpriteRenderer>().enabled = false;
		textBg2.GetComponent<SpriteRenderer>().enabled = true;
	}
}
