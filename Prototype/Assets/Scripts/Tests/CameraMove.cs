using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public Vector3 moveDirectionUp = Vector3.zero;
	public Vector3 moveDirectionDown = Vector3.zero;
	public Vector3 moveDirectionLeft = Vector3.zero;
	public Vector3 moveDirectionRight = Vector3.zero;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (8f, 2f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += moveDirectionLeft * Time.deltaTime;
		} else if (Input.GetKey(KeyCode.RightArrow)){
			transform.position += moveDirectionRight * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.UpArrow)){
			transform.position += moveDirectionUp * Time.deltaTime;
		} else if (Input.GetKey(KeyCode.DownArrow)){
			transform.position += moveDirectionDown * Time.deltaTime;
		}
	}
}
