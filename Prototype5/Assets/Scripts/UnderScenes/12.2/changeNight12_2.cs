using UnityEngine;
using System.Collections;

public class changeNight12_2 : MonoBehaviour {

	public GameObject nightWatch;
	public GameObject dayWatch;
	public GameObject dayCollider;
	public GameObject nightCollider;
	public GameObject people;
	public GameObject night;
	public GameObject day;
	public GameObject coffin;
	public GameObject RalphDCollider;
	public GameObject RalphNCollider;
	public GameObject dayText;
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;
	public GameObject text6;
	public GameObject text7;
	public GameObject text1Collider;
	public GameObject text2Collider;
	public GameObject text3Collider;
	public GameObject text4Collider;
	public GameObject text5Collider;
	public GameObject text6Collider;
	public GameObject text7Collider;
	public GameObject infoCollider;
	public GameObject coffinCollider;


	void OnMouseUpAsButton(){
		nightWatch.GetComponent<SpriteRenderer>().enabled = true;
		nightWatch.GetComponent<BoxCollider2D> ().enabled = true;
		dayWatch.GetComponent<SpriteRenderer>().enabled = false;
		dayWatch.GetComponent<BoxCollider2D> ().enabled = false;
		dayCollider.GetComponent<BoxCollider2D> ().enabled = false;
		nightCollider.GetComponent<BoxCollider2D> ().enabled = true;
		people.GetComponent<SpriteRenderer>().enabled = false;
		night.GetComponent<SpriteRenderer>().enabled = true;
		day.GetComponent<SpriteRenderer>().enabled = false;
		coffin.GetComponent<SpriteRenderer>().enabled = false;
		RalphDCollider.GetComponent<BoxCollider2D> ().enabled = false;
		RalphNCollider.GetComponent<BoxCollider2D> ().enabled = true;
		dayText.GetComponent<MeshRenderer>().enabled = false;
		text1.GetComponent<MeshRenderer> ().enabled = false;
		text2.GetComponent<MeshRenderer> ().enabled = false;
		text3.GetComponent<MeshRenderer> ().enabled = false;
		text4.GetComponent<MeshRenderer> ().enabled = false;
		text5.GetComponent<MeshRenderer> ().enabled = false;
		text6.GetComponent<MeshRenderer> ().enabled = false;
		text7.GetComponent<MeshRenderer> ().enabled = false;
		text1Collider.GetComponent<BoxCollider2D> ().enabled = false;
		text2Collider.GetComponent<BoxCollider2D> ().enabled = false;
		text3Collider.GetComponent<BoxCollider2D> ().enabled = false;
		text4Collider.GetComponent<BoxCollider2D> ().enabled = false;
		text5Collider.GetComponent<BoxCollider2D> ().enabled = false;
		text6Collider.GetComponent<BoxCollider2D> ().enabled = false;
		text7Collider.GetComponent<BoxCollider2D> ().enabled = false;
		infoCollider.GetComponent<BoxCollider2D> ().enabled = true;
		coffinCollider.GetComponent<BoxCollider2D> ().enabled = false;
	}
}
