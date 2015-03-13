using UnityEngine;
using System.Collections;

public class closeObject : MonoBehaviour {

	public GameObject CloseObj;

	void OnMouseDown(){
		CloseObj.GetComponent<SpriteRenderer>().enabled = false;
		CloseObj.GetComponent<BoxCollider2D> ().enabled = false;
	}
}
