﻿using UnityEngine;
using System.Collections;

public class showResetText01 : MonoBehaviour {

	public GameObject MaryCollider;
	public GameObject MaryText2;
	
	
	void OnMouseUpAsButton(){
		MaryCollider.GetComponent<BoxCollider2D> ().enabled = true;
		MaryText2.GetComponent<MeshRenderer>().enabled = false;
		MaryText2.GetComponent<BoxCollider2D> ().enabled = false;
	}
}