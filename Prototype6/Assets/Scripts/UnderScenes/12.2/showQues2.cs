using UnityEngine;
using System.Collections;

public class showQues2 : MonoBehaviour {

	public GameObject Ques0;
	public GameObject Ques0Collider;
	public GameObject textBG1;

	public GameObject Ques1;
	public GameObject Ques1_2;
	public GameObject Ques2;
	public GameObject Ques2_2;
	public GameObject Ques2_3;
	public GameObject textBG2;
	public GameObject textBG3;

	public bool turnOff = true;
	
	private float alpha = 0;

	private void Start(){

	}
	
	void OnMouseUpAsButton(){

		turnOff = false;

		alpha = 0;
		Ques1.GetComponent<MeshRenderer>().enabled = true;
		Ques1_2.GetComponent<MeshRenderer>().enabled = true;
		Ques1_2.GetComponent<BoxCollider2D> ().enabled = true;
		Ques2.GetComponent<MeshRenderer>().enabled = true;
		Ques2_2.GetComponent<MeshRenderer>().enabled = true;
		Ques2_2.GetComponent<BoxCollider2D> ().enabled = true;
		Ques2_3.GetComponent<MeshRenderer>().enabled = true;
		textBG2.GetComponent<SpriteRenderer>().enabled = true;
		textBG3.GetComponent<SpriteRenderer>().enabled = true;

		Ques0.GetComponent<MeshRenderer>().enabled = false;
		Ques0.GetComponent<BoxCollider2D> ().enabled = false;
		Ques0Collider.GetComponent<BoxCollider2D> ().enabled = false;
		textBG1.GetComponent<SpriteRenderer>().enabled = false;
	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		Ques1.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		Ques1_2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		Ques2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		Ques2_2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		Ques2_3.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBG2.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		textBG3.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
	
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 
		else if (turnOff == true) {
			if (alpha >= 0){
				alpha -= 0.03f;
			}
		}
		
	}


}
