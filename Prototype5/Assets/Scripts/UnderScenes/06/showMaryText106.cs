﻿using UnityEngine;
using System.Collections;

public class showMaryText106 : MonoBehaviour {

	public GameObject JoelCollider;
	public GameObject JoelText1;
	public GameObject MaryText1;
	public GameObject MaryText2;

	void OnMouseUpAsButton(){
		JoelCollider.GetComponent<BoxCollider2D>().enabled = false;
		JoelText1.GetComponent<MeshRenderer>().enabled = false;
		JoelText1.GetComponent<BoxCollider2D>().enabled = false;
		MaryText1.GetComponent<MeshRenderer>().enabled = true;
		MaryText1.GetComponent<BoxCollider2D>().enabled = true;
		MaryText2.GetComponent<MeshRenderer>().enabled = true;
		MaryText2.GetComponent<BoxCollider2D>().enabled = true;
	}

}