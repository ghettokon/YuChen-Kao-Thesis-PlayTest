using UnityEngine;
using System.Collections;

public class CameraMoving : MonoBehaviour {

	public float Boundary = 70f;
	public float speed = 5f;

	public float theScreenWidth;
	public float theScreenHeight;

	private Vector3 currentLoc;
	public float zPos = 6f;

	public static bool showUpCursor = false;
	public static bool showDownCursor = false;
	public static bool showLeftCursor = false;
	public static bool showRightCursor = false;



	
	void Start () {
		theScreenWidth = Screen.width;
		theScreenHeight = Screen.height;
	}

	void Update () {

		//Debug.Log (showUpCursor);
		//right
		if (Input.mousePosition.x > theScreenWidth - Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);

			showRightCursor = true;
			showLeftCursor = false;
			showUpCursor = false;
			showDownCursor = false;
		}

		//left
		else if (Input.mousePosition.x < 0 + Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);
		
			showLeftCursor = true;
			showRightCursor = false;
			showUpCursor = false;
			showDownCursor = false;
		}

		//up
		else if (Input.mousePosition.y > theScreenHeight - Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);


			showUpCursor = true;
			showLeftCursor = false;
			showRightCursor = false;
			showDownCursor = false;
		}


		//down
		else if (Input.mousePosition.y < 0 + Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);

			showDownCursor = true;
			showUpCursor = false;
			showLeftCursor = false;
			showRightCursor = false;
		}

		//elsewhere
		else if( Input.mousePosition.y>0+ Boundary && Input.mousePosition.y< theScreenHeight  - Boundary
		        && Input.mousePosition.x>0+ Boundary && Input.mousePosition.x<theScreenWidth - Boundary){

			showUpCursor = false;
			showLeftCursor = false;
			showRightCursor = false;
			showDownCursor = false;
		}

	}

}
