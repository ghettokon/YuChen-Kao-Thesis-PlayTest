using UnityEngine;
using System.Collections;

public class showZoeText104 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject textBg1;
	public GameObject textBg2;
	
	public bool turnOff = true;
	
	private float alpha = 0;
	
	
	private void Start(){
		text2.GetComponent<MeshRenderer>().enabled = true;
		textBg2.GetComponent<SpriteRenderer>().enabled = true;
	}
	
	void OnMouseUpAsButton(){
		if(turnOff==true){
			turnOff=false;
		}

		alpha = 0;
		text2.GetComponent<MeshRenderer>().enabled = true;
		text2.GetComponent<BoxCollider2D>().enabled = true;
		textBg2.GetComponent<SpriteRenderer>().enabled = true;
		
		text1.GetComponent<MeshRenderer>().enabled = false;
		text1.GetComponent<BoxCollider2D>().enabled = false;
		textBg1.GetComponent<SpriteRenderer>().enabled = false;

	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBg2.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
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
