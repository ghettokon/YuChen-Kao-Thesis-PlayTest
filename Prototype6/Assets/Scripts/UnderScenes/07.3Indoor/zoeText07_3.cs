﻿using UnityEngine;
using System.Collections;

public class zoeText07_3 : MonoBehaviour {

	string dialogue = ">Sorry I’m late.";
	
	// Update is called once per frame
	void Update () {
		string textBuffer = dialogue;
		if (dialogue == ">Sorry I’m late.") {
			textBuffer +="\nI was stuck on the road.";
			textBuffer +="\nHave you started the dinner?";
			textBuffer +="\nWhere’s Mom?";
		}
		GetComponent<TextMesh>().text = textBuffer;
	}
}
