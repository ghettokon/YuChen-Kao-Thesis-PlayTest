﻿using UnityEngine;
using System.Collections;

public class showPortals03_1 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject textBgGhost;
	
	public bool turnOff = true;
	
	private float alpha = 0;

	private void Start(){
		
	}
	
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;


		if (!turnOff) {
			alpha = 0;
			text1.GetComponent<MeshRenderer>().enabled = true;
			text1.GetComponent<BoxCollider2D>().enabled = true;
			text2.GetComponent<MeshRenderer>().enabled = true;
			text2.GetComponent<BoxCollider2D>().enabled = true;
			textBgGhost.GetComponent<SpriteRenderer>().enabled = true;
		}

		if (turnOff) {
			//text1.GetComponent<MeshRenderer>().enabled = false;
			text1.GetComponent<BoxCollider2D>().enabled = false;
			//text2.GetComponent<MeshRenderer>().enabled = false;
			text2.GetComponent<BoxCollider2D>().enabled = false;
			//textBgGhost.GetComponent<SpriteRenderer>().enabled = false;
		}


	}
	
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text1.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		text2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBgGhost.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		text1.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		
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