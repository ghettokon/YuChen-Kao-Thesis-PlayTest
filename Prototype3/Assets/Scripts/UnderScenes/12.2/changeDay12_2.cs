using UnityEngine;
using System.Collections;

public class changeDay12_2 : MonoBehaviour {

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
	}

}
