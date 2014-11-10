using UnityEngine;
using System.Collections;

public class CameraGoToMouse : MonoBehaviour {

	private Vector3 center1;
	private Vector3 center2;
	private Vector3 currentLoc;
	private CameraChangeScene script1;
	public float speed = 20f;
	public float zPos = 10f;

	//Set up clickable objects
	public GameObject object1;



	void Start(){
		script1 = object1.GetComponent<CameraChangeScene> ();
		center1 = transform.position;
		center2 = new Vector3(script1.CameraPosx, script1.CameraPosy, object1.transform.position.z);
		currentLoc = transform.position;
	}

	void Update(){

		if(Input.GetMouseButtonDown (0)){
			if (!script1.closeup) {
				if(script1.oldcloseup){
					script1.oldcloseup=false;
					transform.position = new Vector3(center1.x, center1.y, transform.position.z);
				}
			} else {
				if(!script1.oldcloseup){
					script1.oldcloseup=true;
					transform.position = new Vector3(center2.x, center2.y, transform.position.z);
				}
			}
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
		}
		transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);

		//Start Scene
		if(transform.position.x>-30.0f && transform.position.x<65.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -27.0f, 47.0f);
			pos.y = Mathf.Clamp (pos.y, -8.0f, 8.0f);
			transform.position = pos;
		}
	}
}
