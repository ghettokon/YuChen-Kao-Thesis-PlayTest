using UnityEngine;
using System.Collections;

public class CameraChangeScene : MonoBehaviour {

	public Transform Camera;
	public float CameraPosx;
	public float CameraPosy;

	void OnMouseUpAsButton(){
		Camera.transform.position = new Vector3(CameraPosx, CameraPosy, 0f);
	}
}
