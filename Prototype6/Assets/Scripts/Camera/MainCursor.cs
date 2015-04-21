using UnityEngine;
using System.Collections;

public class MainCursor : MonoBehaviour {

	public Texture2D cursorTexture;
	public Texture2D cursorClickImage;
	public Texture2D cursorUpImage;
	public Texture2D cursorDownImage;
	public Texture2D cursorLeftImage;
	public Texture2D cursorRightImage;




	private int cursorSizeX=32;
	private int cursorSizeY=32;

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void  OnGUI () {
		//Debug.Log (CameraMoving.showUpCursor);

		if(Input.GetMouseButton(0)){
			GUI.DrawTexture (new Rect(Event.current.mousePosition.x-cursorSizeX/2, Event.current.mousePosition.y-cursorSizeY/2, cursorSizeX, cursorSizeY), this.cursorClickImage);
		}
		else{
			if(CameraMoving.showUpCursor==false && CameraMoving.showDownCursor==false && CameraMoving.showRightCursor==false && CameraMoving.showLeftCursor==false){
				//Cursor.SetCursor(this.cursorTexture, Vector2.zero, CursorMode.Auto);
				GUI.DrawTexture (new Rect(Event.current.mousePosition.x-cursorSizeX/2, Event.current.mousePosition.y-cursorSizeY/3, cursorSizeX, cursorSizeY), this.cursorTexture);

			}
			else if (CameraMoving.showUpCursor==true){
				//Cursor.SetCursor(this.cursorUpImage, Vector2.zero, CursorMode.Auto);
				GUI.DrawTexture (new Rect(Event.current.mousePosition.x-cursorSizeX/2, Event.current.mousePosition.y-cursorSizeY/2, cursorSizeX, cursorSizeY), this.cursorUpImage);
			}
			else if (CameraMoving.showDownCursor==true){
				GUI.DrawTexture (new Rect(Event.current.mousePosition.x-cursorSizeX/2, Event.current.mousePosition.y-cursorSizeY/2, cursorSizeX, cursorSizeY), this.cursorDownImage);
			}
			else if (CameraMoving.showRightCursor==true){
				GUI.DrawTexture (new Rect(Event.current.mousePosition.x-cursorSizeX/2, Event.current.mousePosition.y-cursorSizeY/2, cursorSizeX, cursorSizeY), this.cursorRightImage);
			}
			else if (CameraMoving.showLeftCursor==true){
				GUI.DrawTexture (new Rect(Event.current.mousePosition.x-cursorSizeX/2, Event.current.mousePosition.y-cursorSizeY/2, cursorSizeX, cursorSizeY), this.cursorLeftImage);
			}

		}
	}
}
