using UnityEngine;
using System.Collections;

public class CameraMoving : MonoBehaviour {

	public float Boundary = 70f;
	public float speed = 5f;

	public float theScreenWidth;
	public float theScreenHeight;

	private Vector3 currentLoc;
	public float zPos = 6f;

	public Texture2D cursorUpImage;
	private bool showUpCursor = false;


	
	void Start () {
		theScreenWidth = Screen.width;
		theScreenHeight = Screen.height;
	}

	void Update () {




		//right
		if (Input.mousePosition.x > theScreenWidth - Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);
		}

		//left
		else if (Input.mousePosition.x < 0 + Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);
		}

		//up
		else if (Input.mousePosition.y > theScreenHeight - Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);

			//not working
			showUpCursor = true;
			if(showUpCursor) {
				Cursor.SetCursor(this.cursorUpImage, Vector2.zero, CursorMode.Auto);
			}
		}

		//down
		else if (Input.mousePosition.y < 0 + Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);
		}


	}

}
