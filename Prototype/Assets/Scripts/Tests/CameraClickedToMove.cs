using UnityEngine;
using System.Collections;

public class CameraClickedToMove : MonoBehaviour {

	private bool toTarget;
	private Vector3 endPoint;
	public float duration = 200.0f;


	
	void Start () {

	}

	void Update () {



		if (Input.GetMouseButtonDown (0)) {
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			if(hit.collider != null){
				toTarget = true;
				endPoint = new Vector3 (hit.point.x, hit.point.y, transform.position.z);
			}
		}

		if (toTarget){ 
			if(Vector3.Distance(transform.position, endPoint)>1) {
			//Vector3 relativePos = endPoint - transform.position ;
			//transform.rigidbody2D.AddForce(relativePos.normalized * duration);
			gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPoint, 1/(duration*(Vector3.Distance(gameObject.transform.position, endPoint))));
			}
		}
	
	}
}
