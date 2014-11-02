using UnityEngine;
using System.Collections;

public class CameraGoToMouse : MonoBehaviour {

	private Vector3 target;
	public float speed = 20f;
	public float zPos = 10f;

	void Start(){
		target = transform.position;
	}

	void Update(){
		if(Input.GetMouseButtonDown (0)){
			target = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			target.z = transform.position.z;
		}
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}

}
