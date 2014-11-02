using UnityEngine;
using System.Collections;

public class CameraGoToMouse : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos = Input.mousePosition;
		Debug.Log (mousePos);
		if (Input.GetMouseButtonDown (0)) {
			transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, 0f));
		}
	}
}
