using UnityEngine;
using System.Collections;

public class MouseHoverText : MonoBehaviour {

	//what to showup when hover
	public GameObject show;

	public float time;

	//Set up the cursor shape when hover the clickable object
	//public Texture2D cursorTexture;
	//public bool cursorEnabled = false;

	void OnMouseEnter(){
		show.GetComponent<MeshRenderer>().enabled = true;

		//Cursor.SetCursor(this.cursorTexture, Vector2.zero, CursorMode.Auto); 
		//this.cursorEnabled = true;
	}
		
	void OnMouseExit(){
		show.GetComponent<MeshRenderer> ().enabled = false;
		//Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); 
		//this.cursorEnabled = false;
	}

}
