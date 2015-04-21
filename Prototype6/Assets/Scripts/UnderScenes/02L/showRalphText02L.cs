using UnityEngine;
using System.Collections;

public class showRalphText02L : MonoBehaviour {

	public GameObject Rtext1;
	public GameObject Rtext2;
	public GameObject Mtext;
	public GameObject textBg1;
	public GameObject textBg2;

	public bool turnOff = true;
	
	private float alpha = 0;




	private void Start(){

	}
	
	void OnMouseUpAsButton(){

		turnOff = false;
		
		alpha = 0;
		Rtext1.GetComponent<MeshRenderer>().enabled = true;
		Rtext1.GetComponent<BoxCollider2D> ().enabled = true;
		Rtext2.GetComponent<MeshRenderer>().enabled = true;
		Rtext2.GetComponent<BoxCollider2D> ().enabled = true;
		textBg2.GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find ("02L-Mary-collider").GetComponent<showMaryText02L> ().turnOff = true;
		
		Mtext.GetComponent<MeshRenderer>().enabled = false;
		Mtext.GetComponent<BoxCollider2D> ().enabled = false;
		textBg1.GetComponent<SpriteRenderer>().enabled = false;


	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		Rtext1.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		Rtext2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBg2.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 
		
	}
}
