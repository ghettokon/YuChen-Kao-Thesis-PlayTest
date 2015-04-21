using UnityEngine;
using System.Collections;

public class showPortal01 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject textBg;
	
	public bool turnOff = true;
	
	private float alpha = 0;

	
	private void Start(){
		text1.GetComponent<MeshRenderer>().enabled = true;
		text2.GetComponent<MeshRenderer>().enabled = true;
		textBg.GetComponent<SpriteRenderer>().enabled = true;
	}
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
//		if(turnOff==true){
//			turnOff=false;
//		}
		
		if (!turnOff) {
			alpha = 0;
			text1.GetComponent<MeshRenderer>().enabled = true;
			text2.GetComponent<MeshRenderer>().enabled = true;
			text2.GetComponent<BoxCollider2D> ().enabled = true;
			textBg.GetComponent<SpriteRenderer>().enabled = true;
		}

		if (turnOff) {
			text2.GetComponent<BoxCollider2D> ().enabled = false;
		}
	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text1.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		text2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBg.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} else if (turnOff == true) {
			if (alpha >= 0){
				alpha -= 0.03f;
			}
		}
		
	}
}
