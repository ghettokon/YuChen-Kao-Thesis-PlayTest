using UnityEngine;
using System.Collections;

public class CameraClickToMove : MonoBehaviour {

	public float duration = 200.0f;
	//private bool toTarget = false;
	//private Vector3 target;
	
	void Start () {
		//target = transform.position;
	}
//test1
//	void Update () {
//		Vector3 clickedPos;
//		Vector3 mousePos = Input.mousePosition;
//		clickedPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, 1f));
//		Vector3 relativePos = clickedPos - transform.position ;
//
//		if(Input.GetMouseButtonDown(0)){
//			transform.rigidbody2D.AddForce(relativePos.normalized * duration);
//		}
//	}

//test2
//	void Update () {
//		
//		if(Input.GetMouseButtonDown(0)){
//
//			Vector3 clickedPos;
//			Vector3 mousePos = Input.mousePosition;
//			clickedPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, 1f));
//			Vector3 relativePos = clickedPos - transform.position ;
//
//			flag = !flag;
//
//			if (flag) {
//				if(!Mathf.Approximately (gameObject.transform.position.magnitude, clickedPos.magnitude)){
//				transform.rigidbody2D.AddForce(relativePos.normalized * duration);
//				}
//			} 
//		}
//	}

//test3
//	void Update(){
//		Vector3 mousePos = Input.mousePosition;
//		Vector3 clickedPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, 1f));
//		Vector3 relativePos = clickedPos - transform.position ;
//
//		Debug.Log (clickedPos);
//
//		if (Input.GetMouseButtonDown (0)) {
//			toTarget = true;
//		}
//
//		if(toTarget && !Mathf.Approximately (gameObject.transform.position.magnitude, clickedPos.magnitude)){
//			toTarget = true;
//			transform.rigidbody2D.AddForce(relativePos.normalized * duration);
//		} else if (toTarget && mousePos == transform.position){
//			toTarget = false;
//		}
//	}

//test4
	void Update(){
		Vector3 mousePos = Input.mousePosition;
		Vector3 clickedPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, 1f));
		Vector3 relativePos = clickedPos - transform.position ;

		if (Input.GetMouseButtonDown (0)) {
			if (Vector3.Distance(transform.position, clickedPos)>1){
				transform.rigidbody2D.AddForce(relativePos.normalized * duration);
			} else if (transform.position == clickedPos){
				transform.rigidbody2D.AddForce(relativePos.normalized * 0);
			}
		}

	}

//test5
//	void Update(){
//		if(Input.GetMouseButtonDown (0)){
//			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//			target.z = transform.position.z;
//			if (Vector3.Distance (transform.position, target) > 1) {
//				transform.position = Vector3.MoveTowards(transform.position, target, duration * Time.deltaTime);
//			}
//
//		}
//	}

}
