using UnityEngine;
using System.Collections;

public class ChangeCursor : MonoBehaviour {

	public Texture2D cursorTexture;

	// Use this for initialization
	void Start () {
		Cursor.SetCursor(this.cursorTexture, Vector2.zero, CursorMode.Auto);
	}
	
	// Update is called once per frame
	void Update () {
		Cursor.SetCursor(this.cursorTexture, Vector2.zero, CursorMode.Auto);
	}
}
