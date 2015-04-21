using UnityEngine;
using System.Collections;

public class closeNote01 : MonoBehaviour {

	public GameObject CloseObj;
	
	void OnMouseDown(){
		CloseObj.GetComponent<SpriteRenderer>().enabled = false;
		CloseObj.GetComponent<BoxCollider2D> ().enabled = false;
		GameObject.Find ("01-note-collider").GetComponent<showNote01> ().turnOff = true;
	}
}
