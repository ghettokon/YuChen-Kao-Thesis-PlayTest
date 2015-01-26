﻿using UnityEngine;
using System.Collections;

public class MouseHoverSprite : MonoBehaviour {

	//what to showup when hover
	public GameObject show;

	//Set up the cursor shape when hover the clickable object
	public Texture2D cursorTexture;
	public bool cursorEnabled = false;

	void OnMouseEnter(){
		show.GetComponent<SpriteRenderer>().enabled = true;
		Cursor.SetCursor(this.cursorTexture, Vector2.zero, CursorMode.Auto); 
		this.cursorEnabled = true;
	}
		
	void OnMouseExit(){
		show.GetComponent<SpriteRenderer> ().enabled = false;
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); 
		this.cursorEnabled = false;
	}

}
