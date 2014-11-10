using UnityEngine;
using System.Collections;

public class CameraChangeScene : MonoBehaviour {

	public Transform Camera;
	public float CameraPosx;
	public float CameraPosy;
	public bool closeup = false;
	public bool oldcloseup = false;
	
	void OnMouseUpAsButton(){
		//Camera.transform.position = new Vector3(CameraPosx, CameraPosy, 0f);
		closeup = true;
		Debug.Log (closeup);
	}
}
