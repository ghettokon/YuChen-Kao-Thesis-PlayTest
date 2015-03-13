using UnityEngine;
using System.Collections;

public class CameraMoving : MonoBehaviour {

	public float Boundary = 50f;
	public float speed = 5f;

	public float theScreenWidth;
	public float theScreenHeight;

	private Vector3 currentLoc;
	public float zPos = 6f;
	
	void Start () {
		theScreenWidth = Screen.width;
		theScreenHeight = Screen.height;
	}

	void Update () {
		if (Input.mousePosition.x > theScreenWidth - Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);
		}
		
		if (Input.mousePosition.x < 0 + Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);
		}
		
		if (Input.mousePosition.y > theScreenHeight - Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);
		}
		
		if (Input.mousePosition.y < 0 + Boundary){
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);
		}
	}

}
