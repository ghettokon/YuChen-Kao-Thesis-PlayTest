using UnityEngine;
using System.Collections;

public class showMaryText101 : MonoBehaviour {

	public GameObject MaryText1;
	public GameObject textBg;
	
	public bool turnOff = true;
	
	private float alpha = 0;
	
	
	private void Start(){
		MaryText1.GetComponent<MeshRenderer>().enabled = true;
		textBg.GetComponent<SpriteRenderer>().enabled = true;
	}
	
	void OnMouseUpAsButton(){

		turnOff = !turnOff;
		
		if (!turnOff) {
			alpha = 0;
			MaryText1.GetComponent<MeshRenderer>().enabled = true;
			MaryText1.GetComponent<BoxCollider2D>().enabled = true;
			textBg.GetComponent<SpriteRenderer>().enabled = true;
		}
		
		if (turnOff) {
			MaryText1.GetComponent<BoxCollider2D> ().enabled = false;
		}
	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		MaryText1.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBg.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
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
