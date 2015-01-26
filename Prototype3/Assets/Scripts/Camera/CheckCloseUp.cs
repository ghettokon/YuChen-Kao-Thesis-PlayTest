using UnityEngine;
using System.Collections;

//link to CameraGoToMouse

public class CheckCloseUp : MonoBehaviour {

	public bool closeup = false;
	public bool oldcloseup = false;
	
	void OnMouseUpAsButton(){
		//Camera.transform.position = new Vector3(CameraPosx, CameraPosy, 0f);
		//closeup = true;
		//Debug.Log (closeup);
	}

	void OnMouseEnter(){
		closeup = true;
		Debug.Log (closeup);
	}
	void OnMouseExit(){
		closeup = false;
		oldcloseup = false;
		//Debug.Log (closeup + "2");
		//Debug.Log (oldcloseup);
	}
}
