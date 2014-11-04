using UnityEngine;
using System.Collections;

public class CameraGoToDoubleClick : MonoBehaviour {

	private float doubleClickStart = -1.0f;
	private bool disableClicks  = false;

	private Vector3 target;
	public float speed = 20f;
	public float zPos = 10f;

	void Start () {
		target = transform.position;
	}

	void OnDoubleClick(){
		Debug.Log ("Double Click");

		//WHEN DOUBLE CLICK
		target = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
		target.z = transform.position.z;
		Debug.Log (target);
	}

	IEnumerator lockClicks(){
		disableClicks = true;
		yield return new WaitForSeconds (0.4f);
		disableClicks = false;
	}

	void Update () {

		if (Input.GetMouseButtonUp(0)){
			if (disableClicks)
				return;
			
			if (doubleClickStart > 0 && (Time.time - doubleClickStart) < 0.4){
				this.OnDoubleClick();
				doubleClickStart = -1;
				lockClicks();
				Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, target, speed * Time.deltaTime);
			}
			else{
				doubleClickStart = Time.time;
			}

		}
	
	}
}
