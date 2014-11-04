using UnityEngine;
using System.Collections;

public class CameraMoveTest : MonoBehaviour {

	private Vector3 target;
	public float speed = 20f;
	public float zPos = 10f;
	
	void Start () {
		target = transform.position;
	}

	void Update () {
		if(Input.GetMouseButtonDown (0)){
			target = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			target.z = transform.position.z;

			if(!Mathf.Approximately (gameObject.transform.position.magnitude, target.magnitude)){
				Vector3 relativePos = target - transform.position ;
				transform.rigidbody2D.AddForce(relativePos.normalized * speed);
			}
		}



		//Debug.Log (target);
		Debug.Log (transform.position);
	}
}
