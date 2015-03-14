using UnityEngine;
using System.Collections;

public class openBox07_1B : MonoBehaviour {

	public GameObject box1;
	public GameObject box2;
	public GameObject key;

	void OnMouseUpAsButton(){
		box1.GetComponent<SpriteRenderer>().enabled = false;
		box2.GetComponent<SpriteRenderer>().enabled = true;
		key.GetComponent<SpriteRenderer>().enabled = true;
		key.GetComponent<BoxCollider2D>().enabled = true;
	}

}
