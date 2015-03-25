using UnityEngine;
using System.Collections;

public class changeDay12_1: MonoBehaviour {

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
	public GameObject nightText;
	public GameObject Ques1;
	public GameObject Ques1_2;
	public GameObject Ques2;
	public GameObject Ques2_2;
	public GameObject Ques2_3;
	public GameObject text1Collider;
	public GameObject text2Collider;
	public GameObject text3Collider;
	public GameObject text4Collider;
	public GameObject text5Collider;
//	public GameObject text6Collider;
	public GameObject text7Collider;
	public GameObject infoCollider;
	public GameObject coffinCollider;
	public GameObject coffinCollider2;
	public GameObject textBg1;
	public GameObject textBg2;
	public GameObject textBg3;

	void OnMouseUpAsButton(){
		nightWatch.GetComponent<SpriteRenderer>().enabled = false;
		nightWatch.GetComponent<BoxCollider2D> ().enabled = false;
		dayWatch.GetComponent<SpriteRenderer>().enabled = true;
		dayWatch.GetComponent<BoxCollider2D> ().enabled = true;
		dayCollider.GetComponent<BoxCollider2D> ().enabled = true;
		nightCollider.GetComponent<BoxCollider2D> ().enabled = false;
		people.GetComponent<SpriteRenderer>().enabled = true;
		night.GetComponent<SpriteRenderer>().enabled = false;
		day.GetComponent<SpriteRenderer>().enabled = true;
		coffin.GetComponent<SpriteRenderer>().enabled = true;
		RalphDCollider.GetComponent<BoxCollider2D> ().enabled = true;
		RalphNCollider.GetComponent<BoxCollider2D> ().enabled = false;
		nightText.GetComponent<MeshRenderer>().enabled = false;
		Ques1.GetComponent<MeshRenderer>().enabled = false;
		Ques1_2.GetComponent<MeshRenderer>().enabled = false;
		Ques1_2.GetComponent<BoxCollider2D> ().enabled = false;
		Ques2.GetComponent<MeshRenderer>().enabled = false;
		Ques2_2.GetComponent<MeshRenderer>().enabled = false;
		Ques2_2.GetComponent<BoxCollider2D> ().enabled = false;
		Ques2_3.GetComponent<MeshRenderer> ().enabled = false;
		text1Collider.GetComponent<BoxCollider2D> ().enabled = true;
		text2Collider.GetComponent<BoxCollider2D> ().enabled = true;
		text3Collider.GetComponent<BoxCollider2D> ().enabled = true;
		text4Collider.GetComponent<BoxCollider2D> ().enabled = true;
		text5Collider.GetComponent<BoxCollider2D> ().enabled = true;
		//text6Collider.GetComponent<BoxCollider2D> ().enabled = true;
		text7Collider.GetComponent<BoxCollider2D> ().enabled = true;
		infoCollider.GetComponent<BoxCollider2D> ().enabled = false;
		coffinCollider.GetComponent<BoxCollider2D> ().enabled = true;
		coffinCollider2.GetComponent<BoxCollider2D> ().enabled = true;
		textBg1.GetComponent<SpriteRenderer>().enabled = false;
		textBg2.GetComponent<SpriteRenderer>().enabled = false;
		textBg3.GetComponent<SpriteRenderer>().enabled = false;
	}

}
