using UnityEngine;
using System.Collections;

public class showQues2 : MonoBehaviour {

	public GameObject Ques0;
	public GameObject Ques1;
	public GameObject Ques1_2;
	public GameObject Ques2;
	public GameObject Ques2_2;
	public GameObject Ques2_3;
	public GameObject Ques0Collider;

	void OnMouseUpAsButton(){
		Ques0.GetComponent<MeshRenderer>().enabled = false;
		Ques0.GetComponent<BoxCollider2D> ().enabled = false;
		Ques1.GetComponent<MeshRenderer>().enabled = true;
		Ques1_2.GetComponent<MeshRenderer>().enabled = true;
		Ques1_2.GetComponent<BoxCollider2D> ().enabled = true;
		Ques2.GetComponent<MeshRenderer>().enabled = true;
		Ques2_2.GetComponent<MeshRenderer>().enabled = true;
		Ques2_2.GetComponent<BoxCollider2D> ().enabled = true;
		Ques2_3.GetComponent<MeshRenderer>().enabled = true;
		Ques0Collider.GetComponent<BoxCollider2D> ().enabled = false;
	}


}
