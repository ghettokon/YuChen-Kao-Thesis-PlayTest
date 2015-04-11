using UnityEngine;
using System.Collections;

public class showBghost08_2 : MonoBehaviour {

	public GameObject ghost;
	public GameObject BDark;
	public GameObject text;

	public bool turnOff = true;
	
	private float alpha = 0;
	
	private void Start(){
		
	}
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;

		if (!turnOff) {
			alpha = 0;
			ghost.GetComponent<SpriteRenderer> ().enabled = true;
			BDark.GetComponent<SpriteRenderer> ().enabled = true;
			text.GetComponent<MeshRenderer> ().enabled = true;
			text.GetComponent<BoxCollider2D> ().enabled = true;
		} else {
			//ghost.GetComponent<SpriteRenderer> ().enabled = false;
			//BDark.GetComponent<SpriteRenderer> ().enabled = false;
			//text.GetComponent<MeshRenderer> ().enabled = false;
			text.GetComponent<BoxCollider2D> ().enabled = false;
		}
	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		ghost.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,alpha);
		BDark.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,alpha);
		text.GetComponent<TextMesh> ().color = new Color (1,1,1,alpha);
		
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
