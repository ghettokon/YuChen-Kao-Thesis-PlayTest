﻿using UnityEngine;
using System.Collections;

public class showText200 : MonoBehaviour {
	
	public GameObject text;
	public GameObject showSound;
	public GameObject particle;
	public GameObject ghost;
	
	public bool turnOff = true;
	
	private float alpha = 0;
	
	private void Start(){
		//text.GetComponent<MeshRenderer>().enabled = true;
	}
	
	void OnMouseUpAsButton(){
		if(turnOff==true){
			turnOff=false;
		}
		showSound.audio.Play();
		particle.renderer.sortingLayerName = "hint";
		text.GetComponent<MeshRenderer>().enabled = true;
		text.GetComponent<BoxCollider2D> ().enabled = true;
		ghost.GetComponent<BoxCollider2D> ().enabled = false;
	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);

		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 
	}

}