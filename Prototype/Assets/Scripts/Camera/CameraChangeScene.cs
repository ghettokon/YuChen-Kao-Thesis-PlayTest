using UnityEngine;
using System.Collections;

//link to CameraGoToMouse

public class CameraChangeScene : MonoBehaviour {

	public bool closeup = false;
	public bool oldcloseup = false;
	
	void OnMouseUpAsButton(){
		//Camera.transform.position = new Vector3(CameraPosx, CameraPosy, 0f);
		//closeup = true;
		Debug.Log (closeup);
	}

	void OnMouseEnter(){
		closeup = true;
	}
	void OnMouseExit(){
		closeup = false;
		oldcloseup = false;
	}
}
