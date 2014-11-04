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

		Vector3 pos = transform.position;
		pos.x = Mathf.Clamp (pos.x, -27.0f, 47.0f);
		pos.y = Mathf.Clamp (pos.y, -8.0f, 8.0f);
		transform.position = pos;
	}
}
