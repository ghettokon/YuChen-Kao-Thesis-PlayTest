﻿using UnityEngine;
using System.Collections;

public class MouseClickTextFade : MonoBehaviour {

	public GameObject text;
	
	public bool turnOff = true;

	private float alpha = 0;

	private void Start(){
		text.GetComponent<MeshRenderer>().enabled = true;

	}
	
	void OnMouseUpAsButton(){
		if(turnOff==true){
			turnOff=false;
		}

		if (!turnOff) {
			alpha = 0;
			text.GetComponent<MeshRenderer>().enabled = true;
		}
	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);


		if (turnOff == false) {
				if(alpha<1){
				alpha += 0.03f;
				}
		} else {
				if (alpha >= 0){
					alpha -= 0.01f;
				}
		}

		if (alpha >= 1) {
			StartCoroutine("wait");
		}
	}

	private IEnumerator wait(){
		yield return new WaitForSeconds(2);
		turnOff = true;
	}
}
