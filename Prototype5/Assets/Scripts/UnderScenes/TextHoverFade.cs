using UnityEngine;
using System.Collections;

public class TextHoverFade : MonoBehaviour {


	public GameObject text;
	
	public bool turnOff = true;
	
	private float alpha = 0;
	
	private void Start(){
		text.GetComponent<MeshRenderer>().enabled = true;
		
	}
	
	void OnMouseEnter(){
		text.GetComponent<MeshRenderer>().enabled = true;
		alpha = 0;
		if(turnOff==true){
			turnOff=false;
		}
	}

	void OnMouseExit(){
		if (alpha <= 0) {
			text.GetComponent<MeshRenderer> ().enabled = false;
		}
		turnOff = true;
	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 

		if (turnOff == true) {
			if (alpha >= 0){
				alpha -= 0.03f;
			}
		}
		

	}
	

}
